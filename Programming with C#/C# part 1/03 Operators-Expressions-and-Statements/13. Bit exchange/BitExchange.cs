using System;


    class BitExchange
    {
        static void Main()
        {
            uint number, numberOp1, bitStart, bitEnd; //Op1 stands for Operation 1.
             

            Console.WriteLine("This program exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of a given\nnumber.");
            Console.Write("Please type in the value of the number: ");
            number = uint.Parse(Console.ReadLine());
            Console.Write("Which in binary numerial system is: ");
            Console.WriteLine("{0:## ## ##}", Convert.ToString(number, 2).PadLeft(32, '0'));

            bitStart = 1 << 3;      // Move 1 three times to the left and save the value to bitStart       0000 1000
            bitStart &= number;     // Get me the value of the third bit form number and save the value to bitStart    
                                    // it will be 0000 1000 or 0000 0000
                   
            if (bitStart != 0)      // In case we have 0000 1000 or smth. different than 0
            {
                bitStart <<= 21;    // Move the third bit to position 24 and save the value to bitStart     0001 0000 ... 0000 
                numberOp1 = number | bitStart;   // Put the value of bit 3 in bit 24 of number and save the result in numberOp1.           
            }
            else                        // In case we have 0000 0000  (bitStart == 0)
            {
                bitStart = 1 << 24;     // Move the first bit to position 24 and save the value to bitStart     0001 0000 ... 0000 
                bitStart = ~bitStart;   // Invert bitStart. The result is 1110 1111 ... 1111
                numberOp1 = number & bitStart;  // Put the value of bit 3 in bit 24 of number and save the result in numberOp1.
            }

            // So far I've taken the value of bit 3 from our number (0 or 1), placed it in the place of bit 24 and saved the 
            // new number to the variable numberOp1. 

            bitEnd = 1 << 24;       // Move 1 twenty four times to the left and save the value to bitEnd   0001 0000 ... 0000
            bitEnd &= number;       // Get me the value of the 24-th bit from number and save the value to bitEnd
                                    // 0001 0000 ... 0000 or 0000 0000 ... 0000
            
            if (bitEnd != 0)        // In case we have 0001 0000 ... 0000 or smth different than 0
            {
                bitEnd >>= 21;      // Move the 24-th bit to position 3 and save the value to bitEnd        0000 1000
                number = numberOp1 | bitEnd;     // Put the value of bit 24 of number in bit 3 of numberOp1 and save 
                                                 // the result in number.
            }
            else
            {
                bitEnd = 1 << 3;    // Move the first bit to position 3 and save the value to bitStart     0000 1000 
                bitEnd = ~bitEnd;   // Invert bitEnd. The result is 1111 0111
                number = numberOp1 & bitEnd;     // Put the value of bit 24 of number in bit 3 of numberOp1 and save 
                                                 // the result in number. This will be the new value of number used by
                                                 // the program continuing from here.
            }
                
            // Up to here I exchange (change the places) of bit 3 and 24. 
            // I'll do exactly the same two more times for bits (4 and 25) and (5 and 26) but without the comments.


            bitStart = 1 << 4;      
            bitStart &= number;    

            if (bitStart != 0)      
            {
                bitStart <<= 21;    
                numberOp1 = number | bitStart;             
            }
            else                       
            {
                bitStart = 1 << 25;     
                bitStart = ~bitStart;   
                numberOp1 = number & bitStart; 
            }
       
            bitEnd = 1 << 25;       
            bitEnd &= number;       

            if (bitEnd != 0)        
            {
                bitEnd >>= 21;      
                number = numberOp1 | bitEnd;    
            }
            else
            {
                bitEnd = 1 << 4;     
                bitEnd = ~bitEnd;   
                number = numberOp1 & bitEnd;   
            }

            // Here ends bit 4 and 25 exchange.

            bitStart = 1 << 5;
            bitStart &= number;

            if (bitStart != 0)
            {
                bitStart <<= 21;
                numberOp1 = number | bitStart;
            }
            else
            {
                bitStart = 1 << 26;
                bitStart = ~bitStart;
                numberOp1 = number & bitStart;
            }

            bitEnd = 1 << 26;
            bitEnd &= number;

            if (bitEnd != 0)
            {
                bitEnd >>= 21;
                number = numberOp1 | bitEnd;
            }
            else
            {
                bitEnd = 1 << 5;
                bitEnd = ~bitEnd;
                number = numberOp1 & bitEnd;
            }

            // Here ends bit 5 and 26 exchange.

            Console.WriteLine(); 
            Console.WriteLine("The value of the new number is: " + number);
            Console.Write("Which in binary numerial system is: ");
            Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
            Console.WriteLine();
        }
    }

