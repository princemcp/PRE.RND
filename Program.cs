// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using PRE.CONSOL.RND;
using PRE.Entities.TD02;
using System.Net.Http.Headers;
using System.Runtime.Serialization;
using System.Text;

class Program
{
    static string baseUrl = "https://83.229.72.244"; //"https://localhost";
    static void Main(string[] args)
    {
        try
        {


            Console.WriteLine("Hello World!");
            string data = "{ " +
                    "\"status\":\"success\"," +
                    "\"statusmsg\":\"Data fetched successfully.\"," +
                    "\"sysdata\":{" +
                        "\"token\":\"eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJVc2VyS2V5IjoiMSIsIlVzZXJOYW1lIjoiYWRtaW4iLCJJc0FkbWluIjoiMSIsImV4cCI6MTY0NDE4NDcwOSwiaXNzIjoiaHR0cDovL3ByaW5jZTM2MC5uZXQiLCJhdWQiOiJodHRwOi8vcHJpbmNlMzYwLm5ldCJ9.S6xD8jBY7U0Rh-XsoVaE9qpYKrTtPSbz78b4tl9369s\"," +
                        "\"expiration\":\"2022-02-06T21:58:29Z\"," +
                        "\"username\":\"admin\"," +
                        "\"userKey\":\"1\"," +
                        "\"isAdmin\":\"1\" " +
                        "}" +
                    "} ";

            ApiMsgModel<userToken> xxx = JsonConvert.DeserializeObject<ApiMsgModel<userToken>>(data);
            //Program.loginTD02();
            Program.loginRMS();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    static void loginRMS()
    {
        baseUrl = "https://localhost:44336/";
        LoginUser userdata = new LoginUser();
        userdata.Username = "admin";
        userdata.Password = "121212";

        //login
        string stringData = JsonConvert.SerializeObject(userdata);
        ApiMsgModel<userToken> data = doPost<userToken>("/api/Auth/login", stringData);

        // data access
        if (data.Status == "success")
        {
            ApiMsgModel<string> OrderInfo_GNCode = doGet<string>("/api/RMS/PRE_OrderInfo/OrderInfo_GNCode", "", data.data.token);
            string stringData2 = JsonConvert.SerializeObject(new PRE_OrderInfoEntity() { orderID = "123", tableKey = 1 });
            ApiMsgModel<PRE_OrderInfoEntity> _PRE_OrderInfoEntity = doPost<PRE_OrderInfoEntity>("/api/RMS/PRE_OrderInfo/Insert", stringData2, data.data.token);
        }

    }

    static void loginTD02()
    {

        LoginUser userdata = new LoginUser();
        userdata.Username = "prince";
        userdata.Password = "121212";

        //login
        string stringData = JsonConvert.SerializeObject(userdata);
        ApiMsgModel<userToken> data = doPost<userToken>("/api/Auth/login", stringData);

        // data access
        if (data.Status == "success")

        {

            // user data insert
            UsersEntity usersEntity = new UsersEntity()
            {
                uID = 5,
                fullName = "Habib Ullah",
                uName = "prince",
                uPass = Encoding.ASCII.GetBytes("121212"),
                phone1 = "+8801912388050",
                emailAdrs = "maximaprince@gmail.com",
                adrsCity = "15/F Dhaka",
                usrCountry = "Bangladesh",
                gMaps = "554564564564.56.44.64.5.4.564",
                lastLoginDate = DateTime.Now.Ticks,
                logoPNG = new byte[] { 0x03, 0x10, 0xFF, 0xFF },
                resetCode = new byte[] { 0x03, 0x10, 0xFF, 0xFF },
                isSysAdmin = true,
                isActive1 = true
            };
            stringData = JsonConvert.SerializeObject(usersEntity);
            ApiMsgModel<UsersEntity> getdata = doPost<UsersEntity>("/api/TD02/Users/Insert", stringData, data.data.token);

            // user data update
            usersEntity = new UsersEntity()
            {
                uID = 5,
                fullName = "Habib Ullah - Prince",
                uName = "prince",
                uPass = Encoding.ASCII.GetBytes("121212"),
                phone1 = "+8801912388050",
                emailAdrs = "maximaprince@gmail.com",
                adrsCity = "15/F Dhaka",
                usrCountry = "Bangladesh",
                gMaps = "554564564564.56.44.64.5.4.564",
                lastLoginDate = DateTime.Now.Ticks,
                logoPNG = new byte[] { 0x03, 0x10, 0xFF, 0xFF },
                resetCode = new byte[] { 0x03, 0x10, 0xFF, 0xFF },
                isSysAdmin = true,
                isActive1 = true
            };
            stringData = JsonConvert.SerializeObject(usersEntity);
            ApiMsgModel<UsersEntity> Updatedata = doPost<UsersEntity>("/api/TD02/Users/Update", stringData, data.data.token);


            // user data get
            usersEntity = new UsersEntity()
            {
                uID = 1
            };
            stringData = JsonConvert.SerializeObject(usersEntity);
            ApiMsgModel<List<UsersEntity>> insertdata = doGet<List<UsersEntity>>("/api/TD02/Users/GetAll", "uID=5", data.data.token);






            // business data
            BusinessesEntity businessesEntity = new BusinessesEntity() { uID = 1 };
            stringData = JsonConvert.SerializeObject(businessesEntity);
            ApiMsgModel<List<BusinessesEntity>> data2 = doGet<List<BusinessesEntity>>("/api/TD02/Businesses/GetAll", stringData, data.data.token);
        }
        else
        {

        }
    }
    static ApiMsgModel<T> doPost<T>(string path, string requestdata)
    {
        try
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(baseUrl);
            var contentType = new MediaTypeWithQualityHeaderValue("application/json");
            client.DefaultRequestHeaders.Accept.Add(contentType);
            HttpContent contentData = new StringContent(requestdata, System.Text.Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PostAsync(path, contentData).Result;
            //if (response.StatusCode.ToString() == "OK")
            //{
            //    string stringJWT = response.Content.ReadAsStringAsync().Result;
            //    UserInfoModel jwt = JsonConvert.DeserializeObject<UserInfoModel>(stringJWT);
            //}
            //else
            //{
            string stringJWT = response.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<ApiMsgModel<T>>(stringJWT);
            //}
        }
        catch (Exception ex)
        {
            return new ApiMsgModel<T>() { Status = "fail", statusmsg = Helps.GetErrorMsg(ex) };
        }
    }
    static ApiMsgModel<T> doPost<T>(string path, string requestdata, string token)
    {
        try
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(baseUrl);
            var contentType = new MediaTypeWithQualityHeaderValue("application/json");
            client.DefaultRequestHeaders.Accept.Add(contentType);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            HttpContent contentData = new StringContent(requestdata, System.Text.Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PostAsync(path, contentData).Result;
            //if (response.StatusCode.ToString() == "OK")
            //{
            //    string stringJWT = response.Content.ReadAsStringAsync().Result;
            //    UserInfoModel jwt = JsonConvert.DeserializeObject<UserInfoModel>(stringJWT);
            //}
            //else
            //{
            string stringJWT = response.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<ApiMsgModel<T>>(stringJWT);
            //}
        }
        catch (Exception ex)
        {
            return new ApiMsgModel<T>() { Status = "fail", statusmsg = Helps.GetErrorMsg(ex) };
        }
    }
    static ApiMsgModel<T> doGet<T>(string path, string requestdata, string token)
    {
        try
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(baseUrl);
            var contentType = new MediaTypeWithQualityHeaderValue("application/json");
            client.DefaultRequestHeaders.Accept.Add(contentType);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            HttpResponseMessage response = client.GetAsync(path + "?" + requestdata).Result;
            string stringJWT = response.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<ApiMsgModel<T>>(stringJWT);
        }
        catch (Exception ex)
        {
            return new ApiMsgModel<T>() { Status = "fail", statusmsg = Helps.GetErrorMsg(ex) };
        }
    }

    //static string JsonToQuery(this string jsonQuery)
    //{
    //    string str = "?";
    //    str += jsonQuery.Replace(":", "=").Replace("{", "").
    //                Replace("}", "").Replace(",", "&").
    //                    Replace("\"", "");
    //    return str;
    //}



    [DataContract]
    public class ApiMsgModel<T>
    {
        [DataMember]
        public string Status { get; set; }
        [DataMember]
        public string statusmsg { get; set; }
        [DataMember]
        public T data { get; set; }
    }
    [DataContract]
    public class userToken
    {
        [DataMember]
        public string token { get; set; }
        [DataMember]
        public string expiration { get; set; }
        [DataMember]
        public string username { get; set; }
        [DataMember]
        public string isAdmin { get; set; }
        [DataMember]
        public string userKey { get; set; }
    }
    public class Helps
    {
        public static string GetErrorMsg(Exception ex)
        {
            return ex.Message;
        }
    }

    public class LoginUser
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}