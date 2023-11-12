// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;

Console.WriteLine("Hello, World!");


var plaintext = "Hello world 123456789/*-+!@#$%^&*()-=_+";

Console.WriteLine();
Console.WriteLine("** RSA **");
var rsaKey = EncryptProvider.CreateRsaKey();

var publicKey = rsaKey.PublicKey;
var privateKey = rsaKey.PrivateKey;
var encrypted = string.Empty;
var decrypted = string.Empty;


encrypted = EncryptProvider.RSAEncrypt(publicKey, plaintext);

encrypted = EncryptProvider.RSAEncrypt(publicKey, plaintext, RSAEncryptionPadding.Pkcs1);

decrypted = EncryptProvider.RSADecrypt(privateKey, encrypted, RSAEncryptionPadding.Pkcs1);


Console.WriteLine("Encrypted: " + encrypted);
Console.WriteLine("Decrypted: " + decrypted);

Console.WriteLine("\n\n\n"+"publicKey " + publicKey+"\n\n\n");
Console.WriteLine("\n\n\n"+"privateKey " + privateKey+ "\n\n\n");