using System;
using System.Reflection;
using System.IO;
using System.Security.Cryptography;
using System.Text;

class Program {
    static void Main() {
        var asm = Assembly.LoadFrom("/Users/dyn/Documents/Coding/Project/exambro-mac/Application/LibraryExam.dll");
        var tInit = asm.GetType("IPQ8pw8fmWBhONI5hK.XyoP6ayWD67QhKApbq");
        var mInit = tInit?.GetMethod("X50DCtxVLY", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static);
        mInit?.Invoke(null, null);

        var tBase32 = asm.GetType("LibraryExam.encryption+Base32Encryption");
        var mB32 = tBase32?.GetMethod("ByteArrayToBase36String", BindingFlags.Public | BindingFlags.Static);

        byte[] cipherBytes = Convert.FromHexString("745C2479DDF5B5ED84037BE28CD11236");
        string b32 = (string)mB32?.Invoke(null, new object[] { cipherBytes });
        Console.WriteLine("Base32 output: " + b32);
        Console.WriteLine("Expected:      Y27EBKH8H5F8VZVQ86UJUE4ZNA");
        Console.WriteLine("Match? " + (b32 == "Y27EBKH8H5F8VZVQ86UJUE4ZNA"));
    }
}
