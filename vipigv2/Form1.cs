using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium.Support.UI;
using System.Text.RegularExpressions;
using System.IO;

namespace vipigv2
{
    public partial class Form1 : Form
    {
        bool run = true;
        string file_acc_path = "acc.txt";
        ChromeDriver driverig;
        ChromeDriver driverinss;
        private string htmlContent;

        public Form1()
        {
            InitializeComponent();
            dataGridView1.AllowUserToResizeColumns = false;
            //kiểm tra file có tồn tại ko
            if (File.Exists(file_acc_path))
            {
                //lấy dữ liệu từ file
                string data_acc = File.ReadAllText(file_acc_path);
                //kiểm tra fiel có dữ liệu không
                if (!string.IsNullOrEmpty(data_acc))
                {
                    input_username_Vipig.Text = Regex.Match(data_acc, "user_vipig=(.*?);").Groups[1].Value;
                    input_password_Vipig.Text = Regex.Match(data_acc, "pass_vipig=(.*?);").Groups[1].Value;
                    input_username_ins.Text = Regex.Match(data_acc, "user_ins=(.*?);").Groups[1].Value;
                    input_password_ins.Text = Regex.Match(data_acc, "pass_ins=(.*?);").Groups[1].Value;
                }
            }
            else
            {
                //nếu file ko tồn tại thì tạo ra file mới
                File.Create(file_acc_path);
            } 
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            run = false;
        }

        private void btn_Star_Click(object sender, EventArgs e)
        {
            run = true;
            //lấy thông tin từ ô nhập
            //username VIpig
            //Trim() xóa ký tự tự trống đầu cuối
            string username_vipigs = input_username_Vipig.Text.Trim();
            string password_vipigs = input_password_Vipig.Text.Trim();
            string username_inss = input_username_ins.Text.Trim();
            string password_inss = input_password_ins.Text.Trim();

            //kiểm tra ô nhập nếu đủ cho chạy tiếp
            if(!string.IsNullOrEmpty(username_vipigs)&&
                !string.IsNullOrEmpty(password_vipigs) &&
                !string.IsNullOrEmpty(username_inss) &&
                !string.IsNullOrEmpty(password_inss))
            {
                Thread t = new Thread(() =>
               {
                   ChromeDriver driverVipig = OpenChrome("https://vipig.net/");
                   if (driverVipig != null)
                   {
                       //nghỉ 2 giây
                       delay(2);
                       driverVipig.FindElementByXPath("/html/body/div[1]/div/div[2]/div/div/div[3]/div/button").Click();
                       delay(1);
                       driverVipig.FindElementByName("username").Clear();
                       char[] arrayuser = username_vipigs.ToCharArray();
                       foreach (var user in arrayuser)
                       {
                           driverVipig.FindElementByName("username").SendKeys(user.ToString());
                           Thread.Sleep(150);
                       }

                       driverVipig.FindElementByName("password").Clear();
                       char[] arraypass = password_vipigs.ToCharArray();
                       foreach (var pass in arraypass)
                       {
                           driverVipig.FindElementByName("password").SendKeys(pass.ToString());
                           Thread.Sleep(150);
                       }
                       delay(1);
                       //tiến hành click
                       driverVipig.FindElementByName("submit").Click();
                       delay(2);
                       bool islogin = false;
                       try
                       {
                           var alert = driverVipig.SwitchTo().Alert();
                           string texterr = alert.Text;
                           alert.Accept();
                           driverVipig.Quit();
                           show_error(texterr);
                       }
                       catch
                       {
                           islogin = true;
                       }
                       if (islogin)
                       {
                           //set info
                           this.Invoke(new Action(() =>
                           {
                               //set username
                               IWebElement usernameElement = driverVipig.FindElementByXPath("//h2[contains(text(),'Chào mừng')]/i");
                               string username = usernameElement.Text;
                               my_user.Text = username;
                               //set xu
                               my_xu.Text = driverVipig.FindElementById("soduchinh").Text;
                           }));
                           //instagram login
                           ChromeDriver driverins = OpenChrome("https://www.instagram.com/", true);
                           delay(2);
                           driverins.FindElementByName("username").SendKeys(username_inss);
                           driverins.FindElementByName("password").SendKeys(password_inss);
                           delay(2);
                           IWebElement loginButton = driverins.FindElement(By.XPath("//button[contains(., 'Log in')]"));
                           loginButton.Click();

                           delay(3);
                           if (check(driverins, By.XPath("/html/body/div[2]/div/div/div[2]/div/div/div/div[1]/div[1]/div[2]/section/main/div/div/div/div")))
                           {

                               driverins.FindElementByXPath("/html/body/div[2]/div/div/div[2]/div/div/div/div[1]/div[1]/div[2]/section/main/div/div/div/div").Click();

                           }
                           else
                           {
                               if (check(driverins, By.XPath("//div[contains(@class, '_ab2z')]")))
                               {
                                   show_error(driverins.FindElementByXPath("//div[contains(@class, '_ab2z')]").Text);
                                   driverins.Quit();
                                   driverVipig.Quit();
                                   return;
                               }
                           }
                           //kiểm tra nếu bấm nút Stop sẽ dừng
                           if (!run)
                           {
                               driverVipig.Quit();
                               driverins.Quit();
                               return;
                           }
                           driverinss = driverins;
                           driverig = driverVipig;
                           while (run)
                           {
                               if (!run)
                               {
                                   driverVipig.Quit();
                                   driverins.Quit();
                                   return;
                               }
                               var random = new Random();
                               //int rand = random.Next(1, 3);
                               int rand = 1;
                               if (rand == 1)
                               {
                                   //like
                                   start_like();
                               }
                               else if (rand == 2)
                               {
                                   start_flow();
                                   //flow
                               }
                               else if (rand == 3)
                               {
                                   //cmt
                               }
                           }

                       }






                   }
                   else
                   {
                       show_error("Vui lòng cập nhật chromedrive.exe");
                   }

               })
                {
                    IsBackground = true
                };
                t.Start();

            }
            else
            {
                show_error("Vui lòng nhập đầy đủ thông tin");
            }
        }

        //hàm show tin nhắn lỗi
        void show_error(string message)
        {
            MessageBox.Show(message, "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //hàm mở chrome
        ChromeDriver OpenChrome(string url, bool size = false, bool show = true)
        {
            ChromeOptions options = new ChromeOptions();
            //kiểm tra nếu show = false thì sẽ ẩn chrome
            if (!show)
            {
                options.AddArgument("headless");
            }
            if (size)
            {
                options.AddArgument("--window-size=370,576");
            }
            //để trogn try catch nếu không khi chưa thêm chromedriver.exe sẽ bị lỗi
            ChromeDriverService service;
            try 
            {
                service = ChromeDriverService.CreateDefaultService();
                service.HideCommandPromptWindow = true;
            }
            catch
            {
                return null;
            }
            ChromeDriver driver = new ChromeDriver(service, options);
            try
            {
                //vào url mã đã truyền vào và trả lại driver
                driver.Url = url;
                driver.Navigate();
                return driver;
            }
            catch
            {
                return null;
            }
            
        }

        //hàm sleep
        void delay(int s)
        {
            Thread.Sleep(TimeSpan.FromSeconds(s));
        }
        //check elemnt tồn tại
        bool check (ChromeDriver driver, By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch
            {
                return false;
            }
        }
        //like
        private void start_like()
        {
            driverig.Url = "https://vipig.net/kiemtien/";
            driverig.Navigate();
            delay(2);
            var all_jobs = driverig.FindElementById("dspost").FindElements(By.TagName("button"));
            int tab = 0;
            foreach (var button in all_jobs)
            {
                
                if (!run)
                {
                    driverig.Quit();
                    driverinss.Quit();
                    return;
                }
                //lấy url 
                string url = button.GetAttribute("title").Replace("'", "");
                dataGridView1.Invoke(new Action(() =>
                {
                    tab = dataGridView1.Rows.Add(tab, "Like", input_username_ins.Text, url , "Bắt đầu");
                }));
                button.Click();
                
                driverinss.Url = url;
                driverinss.Navigate();
                dataGridView1.Rows[tab].Cells[4].Value = "Đang tiến hành like";
                delay(2);
                try
                {
                    IWebElement likeButton = driverinss.FindElement(By.CssSelector("svg[aria-label='Like']"));
                    if (likeButton != null)
                    {
                        likeButton.Click();
                    }
                }
                catch
                {
                    // Xử lý nếu không tìm thấy nút like
                }
                //next sang tab vừa mở và đóng
                driverig.SwitchTo().Window(driverig.WindowHandles.Last());
                driverig.Close();
                delay(1);
                //quay lại cửa sổ thứ nhất
                driverig.SwitchTo().Window(driverig.WindowHandles.First());
                dataGridView1.Rows[tab].Cells[4].Value = "Đang tiến hành nhận tiền";
                delay(3);
                IJavaScriptExecutor java = driverig;
                java.ExecuteScript("document.getElementsByClassName('btn-success')[0].click()");
                delay(5);
                dataGridView1.Rows[tab].Cells[4].Value = "Hoàn thành";
                //cập nhập lại số dư
                this.Invoke(new Action(() =>
                {
                    my_xu.Text = driverig.FindElementById("soduchinh").Text;

                }));
                //nghỉ 5 - 10s
                delay(new Random().Next(5, 10));
                if (!run)
                {
                    driverig.Quit();
                    driverinss.Quit();
                    return;
                }
            }
        }

        //flow
        private void start_flow()
        {
            driverig.Url = "https://vipig.net/kiemtien/subcheo/";
            driverig.Navigate();
            delay(2);
            var all_jobs = driverig.FindElementById("dspost").FindElements(By.TagName("button"));
            int tab = 0;
            int nv = 0;
            List<int> list = new List< int > ();
            foreach (var button in all_jobs)
            {

                if (!run)
                {
                    driverig.Quit();
                    driverinss.Quit();
                    return;
                }
                //lấy url 
                string url = "https://www.instagram.com/"+button.GetAttribute("title").Replace("'", "");
                dataGridView1.Invoke(new Action(() =>
                {
                    tab = dataGridView1.Rows.Add(tab, "Flow", input_username_ins.Text, url, "Bắt đầu");
                }));
                list.Add(tab);
                button.Click();

                driverinss.Url = url;
                driverinss.Navigate();
                dataGridView1.Rows[tab].Cells[4].Value = "Đang tiến hành flow";
                delay(2);
                try
                {
                    
                    IWebElement followButton = driverinss.FindElement(By.XPath("//div[contains(@class, 'x9f619')]/button"));
                    followButton.Click();
                }
                catch
                {
                    // Xử lý nếu không tìm thấy nút like
                }
                //next sang tab vừa mở và đóng
                driverig.SwitchTo().Window(driverig.WindowHandles.Last());
                driverig.Close();
                delay(1);
                //quay lại cửa sổ thứ nhất
                driverig.SwitchTo().Window(driverig.WindowHandles.First());
                dataGridView1.Rows[tab].Cells[4].Value = "Đang chờ hoàn thành đủ NV để nhận tiền";
                delay(3);
                //lớn hơn 4 thì bấm nhận tiền
                nv++;
                if (nv > 4)
                {
                    driverig.FindElementById("nhanall").Click();
                    delay(5);
                    foreach(var a in list)
                    {
                        dataGridView1.Rows[tab].Cells[4].Value = "Hoàn thành";
                    }
                    
                    //cập nhập lại số dư
                    this.Invoke(new Action(() =>
                    {
                        my_xu.Text = driverig.FindElementById("soduchinh").Text;

                    }));
                    nv = 0;
                }
                
                //nghỉ 5 - 10s
                delay(new Random().Next(5, 10));
                if (!run)
                {
                    driverig.Quit();
                    driverinss.Quit();
                    return;
                }
                
            }
        }
    }
}
