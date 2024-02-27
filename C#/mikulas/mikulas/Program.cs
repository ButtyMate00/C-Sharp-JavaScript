// See https://aka.ms/new-console-template for more information
Console.WriteLine("| \\__ `\\O/  `--  {}    \\}    {/\r\n\\    \\_(~)/______/=____/=____/=*\r\n \\=======/    //\\\\  >\\/> || \\> \r\n----`---`---  `` `` ```` `` ``");

Random  rnd = new Random();

Byte[] b = new Byte[1];
rnd.NextBytes(b);
Console.WriteLine(b.GetValue(0));
for (int i = b[0]; i > -1; i--)
try
{
    Console.WriteLine("        .\r\n      ,i \\\r\n    ,' 8b \\\r\n  ,;o  `8b \\\r\n ;  Y8. d8  \\\r\n-+._ 8: d8. i:\r\n    `:8 `8i `8\r\n      `._Y8  8:  ___\r\n         `'---Yjdp  \"8m._\r\n              ,\"' _,o9   `m._\r\n              | o8P\"   _.8d8P`-._\r\n              :8'   _oodP\"   ,dP'`-._\r\n               `: dd8P'   ,odP'  do8'`.\r\n                 `-'   ,o8P'  ,o8P' ,8P`.\r\n                   `._dP'   ddP'  ,8P' ,..\r\n                      \"`._ PP'  ,8P' _d8'L..__\r\n                          `\"-._88'  .PP,'7 ,8.`-.._\r\n                               ``'\"--\"'  | d8' :8i `i.\r\n                                         l d8  d8  dP/\r\n                                          \\`' J8' `P'\r\n                                           \\ ,8F  87\r\n                                           `.88  ,'\r\n                                            `.,-' mh");
    b[0]--;
}
catch (Exception e)
{
    Console.WriteLine(e.GetType());
}
Console.WriteLine(b[0]);
Console.ReadLine();