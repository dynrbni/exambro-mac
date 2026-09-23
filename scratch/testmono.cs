using System;
using LibraryExam;

class Test {
    static void Main() {
        try {
            Console.WriteLine("Reading config with GetConfigure...");
            var cfg = new GetConfigure();
            var appConfig = cfg.ReadConfig(false);
            Console.WriteLine("ReadConfig succeeded!");
            Console.WriteLine("jenisapps: " + appConfig.jenisapps);
            Console.WriteLine("getagenturl: " + appConfig.getagenturl);
            Console.WriteLine("parOnline: " + appConfig.parOnline);
            Console.WriteLine("OnlineUrl: " + appConfig.OnlineUrl);
            Console.WriteLine("ModeUjian: " + appConfig.ModeUjian);

            Console.WriteLine("\nCalling getAgent.GetWorkToke()...");
            string workToken = getAgent.GetWorkToke();
            Console.WriteLine("WORK TOKEN: [" + workToken + "]");

            Console.WriteLine("\nCalling getAgent.GetSemi()...");
            string semiToken = getAgent.GetSemi();
            Console.WriteLine("SEMI TOKEN: [" + semiToken + "]");

            string encryptedOnline = encryption.EncryptedToke(workToken, encryption.passPhraseOnline);
            Console.WriteLine("ENCRYPTED ONLINE TOKEN: [" + encryptedOnline + "]");

            string encryptedSemi = encryption.EncryptedToke(semiToken, encryption.passPhraseOnline);
            Console.WriteLine("ENCRYPTED SEMI TOKEN: [" + encryptedSemi + "]");
        } catch (Exception ex) {
            Console.WriteLine("Exception: " + ex);
        }
    }
}
