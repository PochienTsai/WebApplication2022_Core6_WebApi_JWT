namespace WebApplication2022_Core6_WebApi_JWT.JwtServices
{
    public static class Settings   // 注意 關鍵字 static
    {
        public static string Secret = "MIS2000Lab20210605ABCDEFGHIJK1234567890";   // 建議修改這裡的數值，改成您自己的！
        // 注意 ***** 關鍵字 static

        // 也可以寫在 appsettings.json檔案。請參閱 https://www.cnblogs.com/nsky/p/10312101.html
    }
    // 這個類別是用來存放 JWT的金鑰，這個金鑰是用來加密與解密 JWT的內容。

    // 鹽(Salt)在密碼學中，是指在雜湊之前將雜湊內容(例如密碼)的任意固定位置插入特定的字串，以增加雜湊的強度。
    // 這個在雜湊中加入字串的方式稱為[加鹽]。其作用是讓加鹽後的雜湊結果與沒有加鹽的雜湊結果不同。在不同的應用
    // 情境中，這個處理可以增加額外的安全性。在大部分情況下，鹽是不需要保密的。鹽是可以隨機產生的字串，
    // 其插入的位置也是隨意而定
}
