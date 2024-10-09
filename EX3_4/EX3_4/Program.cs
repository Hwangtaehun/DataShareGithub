byte bit = (byte)0x3A;
byte mask = (byte)0xF0;
Console.WriteLine($"Bit AND: {bit:X} & {mask:X} => {(bit & mask):X}");

bit = (byte)0x3A;
mask = (byte)0x0F;
Console.WriteLine($"Bit OR: {bit:X} | {mask:X} => { (bit | mask):X}");
Console.WriteLine($"Bit XOR: {bit:X} ^ {mask:X} => {(bit ^ mask):X}");
Console.WriteLine($"Bit NOT: ~{bit:X} => {(byte)(~bit):X} \n");

sbyte mvData = (sbyte)25;
Console.WriteLine($"Bit LeftMove : {mvData} << 2 => {mvData << 2}");

mvData = 80;
Console.WriteLine($"Bit RightMove : {mvData} >> 2 => {mvData >> 2}");

mvData = -127;
Console.WriteLine($"Bit RightMove : {mvData} >> 2 => {mvData >> 2}");