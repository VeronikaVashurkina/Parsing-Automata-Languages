using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Class1
    {
        enum States
        {
            S, E, F, A1, A2, A3, A4, A5, A6, A7, A8, A9, A10,
            A11, A12, A13, A14, A15, A16, A17, A18, A19, A20,
            A21, A22, A23, A24, A25, A26, A27, A28, A29, A30,
            A31, A32, A33, A34, A35, A36, A37, A38, A39, A40,
            A41, A42, A43, A44, A45, A46, A47, A48, A49, A50
        };

        int symbol_number;
        int length;
        int id;
        int constant;
        int id_length;
        int constant_length;



        private string res;
        private string error;

        public int Synbol_Number()
        {
            return symbol_number;
        }

        public string GetError()
        {
            return error;
        }

        public string GetResult()
        {
            return res;
        }

        public List<string> ID { get; set; }
        public List<string> Constants { get; set; }
       
        public Class1()
        {
            ID = new List<string>();
            Constants = new List<string>();
            symbol_number = 0;
            length = 0;
            id = 0;
            constant = 0;
            id_length = 0;
            constant_length = 0;
        }

        public void TestString(string str)
        {
            str = str.ToUpper();
            States state = States.S;
            length = str.Length;
            symbol_number = 0;
            error = null;

            while ((state != States.F) && (state != States.E) && (symbol_number < length))
            {
                char symbol = str[symbol_number];
                symbol_number++;

                switch (state)
                {
                    case States.S:
                        {
                            if (symbol == ' ')
                            {
                                state = States.S;
                            }
                            else
                            {
                                if (symbol == 'W')
                                {
                                    state = States.A1;
                                }
                                else
                                {
                                    state = States.E;
                                    error = "Ошибка ввода! Ожидался символ W или пробел";
                                }
                            }
                            break;
                        }

                    case States.A1:
                        {
                            if (symbol == 'I')
                            {
                                state = States.A2;
                            }
                            else
                            {

                                state = States.E;
                                error = "Ошибка ввода! Ожидался символ I";

                            }
                            break;
                        }

                    case States.A2:
                        {
                            if (symbol == 'T')
                            {
                                state = States.A3;
                            }
                            else
                            {

                                state = States.E;
                                error = "Ошибка ввода! Ожидался символ T";

                            }
                            break;
                        }

                    case States.A3:
                        {
                            if (symbol == 'H')
                            {
                                state = States.A4;
                            }
                            else
                            {

                                state = States.E;
                                error = "Ошибка ввода! Ожидался символ H";

                            }
                            break;
                        }

                    case States.A4:
                        {
                            if (symbol == ' ')
                            {
                                state = States.A5;
                            }
                            else
                            {

                                state = States.E;
                                error = "Ошибка ввода! Ожидался пробел";

                            }
                            break;
                        }


                    case States.A5:
                        {
                            if (symbol == ' ')
                            {
                                state = States.A5;
                            }
                            else
                            {


                                if ((char.IsLetter(symbol)) || (symbol == '_'))
                                {
                                    id = symbol_number - 1;                                    
                                        id_length++;
                                    state = States.A6;
                                    
                                   
                                }
                                else
                                {
                                    

                                     
                                        
                         
                                            state = States.E;
                                            error = "Ошибка ввода! Ожидался ввод букв от A до Z или символов: пробел, _ ";
                                       
                                    
                                    
                                }
                                

                            }
                            break;
                        }

                    case States.A6:
                        {


                            if ((char.IsLetter(symbol)) || (symbol == '_') || (char.IsDigit(symbol)))
                            {
                                id_length++;
                                state = States.A6;
                            }
                            else
                            {
                                string ID_string = str.Substring(id, id_length);
                                if ((ID_string == "DO") || (ID_string == "WITH") || (ID_string == "DIV") || (ID_string == "MOD"))
                                {
                                    state = States.E;
                                    error = "Ошибка ввода! идентификатор не может быть зарезервированным словом.";
                                    symbol_number--;
                                }
                                else
                                {
                                    if (id_length > 8)
                                    {
                                        state = States.E;
                                        error = "Ошибка ввода! Длина символа не дложна превышать 8 знаков";
                                        symbol_number--;
                                    }
                                    else
                                    {
                                        ID.Add(ID_string);

                                        if (symbol == ',')
                                        {
                                            state = States.A5;
                                            id_length = 0;
                                        }
                                        else
                                        {
                                            if (symbol == '.')
                                            {
                                                state = States.A7;
                                                id_length = 0;
                                            }
                                            else
                                            {
                                                if (symbol == ' ')
                                                {
                                                    state = States.A8;
                                                    id_length = 0;
                                                }


                                                else
                                                {
                                                    state = States.E;
                                                    error = "Ошибка ввода! Ожидался ввод букв от A до Z,чисел от 0 до 9 или символ пробел, '_', ',', '.'";
                                                }


                                            }
                                        }


                                    }
                                }

                            }
                            break;
                        }
                    case States.A7:
                        {



                            if ((char.IsLetter(symbol)) || (symbol == '_'))
                            {
                                id = symbol_number - 1;
                                id_length++;
                                state = States.A9;
                                
                              
                            }
                           


                                    else
                                    {
                                        state = States.E;
                                        error = "Ошибка ввода! Ожидался ввод букв от A до Z или символa '_'.";
                                    }
                                
                            

                            break;
                        }
                    case States.A9:
                        {




                            if ((char.IsLetter(symbol)) || (symbol == '_') || (char.IsDigit(symbol)))
                            {
                                id_length++;
                                state = States.A9;
                            }
                            else
                            {
                                string ID_string = str.Substring(id, id_length);
                                if ((ID_string == "DO") || (ID_string == "WITH") || (ID_string == "DIV") || (ID_string == "MOD"))
                                {
                                    state = States.E;
                                    error = "Ошибка ввода! идентификатор не может быть зарезервированным словом.";
                                    symbol_number--;
                                }
                                else
                                {
                                    if (id_length > 8)
                                    {
                                        state = States.E;
                                        error = "Ошибка ввода! Длина символа не дложна превышать 8 знаков";
                                        symbol_number--;
                                    }

                                    else
                                    {
                                        ID.Add(ID_string);
                                        if (symbol == ',')
                                        {
                                            state = States.A5;
                                            id_length = 0;
                                        }
                                        else
                                        {

                                            if (symbol == ' ')
                                            {
                                                state = States.A8;
                                                id_length = 0;
                                            }


                                            else
                                            {
                                                state = States.E;
                                                error = "Ошибка ввода! Ожидался ввод букв от A до Z, чисел от 0 до 9, или символов 'пробел', ',', '_'.";
                                            }
                                        }

                                    }
                                }

                            }
                            break;
                        }

                    case States.A8:
                        {
                            if (symbol == ',')
                            {
                                state = States.A5;
                            }
                            else
                            {
                                if (symbol == 'D')
                                {
                                    state = States.A10;
                                }
                                else
                                {
                                    state = States.E;
                                    error = "Ошибка ввода! Ожидался символ D или пробел";
                                }
                            }
                            break;
                        }

                    case States.A10:
                        {
                            if (symbol == 'O')
                            {
                                state = States.A11;
                            }
                            else
                            {

                                state = States.E;
                                error = "Ошибка ввода! Ожидался символ O";

                            }
                            break;
                        }
                    case States.A11:
                        {
                            if (symbol == ' ')
                            {
                                state = States.A11;
                            }
                            else
                            {


                                if ((char.IsLetter(symbol)) || (symbol == '_'))
                                {
                                    id = symbol_number - 1;
                                    id_length++;
                                    state = States.A12;
                                    
                                }
                               


                                        else
                                        {
                                            state = States.E;
                                            error = "Ошибка ввода! Ожидался ввод букв от A до Z или символов: пробел, _ ";
                                        }
                                    
                                
                            }
                            break;
                        }

                    case States.A12:
                        {




                            if ((char.IsLetter(symbol)) || (symbol == '_') || (char.IsDigit(symbol)))
                            {
                                id_length++;
                                state = States.A12;
                            }
                            else
                            {
                                string ID_string = str.Substring(id, id_length);
                                if ((ID_string == "DO") || (ID_string == "WITH") || (ID_string == "DIV") || (ID_string == "MOD"))
                                {
                                    state = States.E;
                                    error = "Ошибка ввода! идентификатор не может быть зарезервированным словом.";
                                    symbol_number--;
                                }
                                else
                                {
                                    if (id_length > 8)
                                    {
                                        state = States.E;
                                        error = "Ошибка ввода! Длина символа не дложна превышать 8 знаков";
                                        symbol_number--;
                                    }

                                    else
                                    {
                                        ID.Add(ID_string);
                                        if (symbol == ':')
                                        {
                                            state = States.A15;
                                            id_length = 0;
                                        }
                                        else
                                        {
                                            if (symbol == '[')
                                            {
                                                state = States.A13;
                                                id_length = 0;
                                            }
                                            else
                                            {
                                                if (symbol == ' ')
                                                {
                                                    state = States.A14;
                                                    id_length = 0;
                                                }
                                                else
                                                {
                                                    state = States.E;
                                                    error = "Ошибка ввода! Ожидался ввод букв от A до Z,чисел от 0 до 9 или символ пробел, '_', ']', ':'";
                                                }
                                            }

                                        }

                                    }
                                }
                            }
                            break;
                        }

                    case States.A14:
                        {
                            if (symbol == ' ')
                            {
                                state = States.A14;
                            }
                            else
                            {
                                if (symbol == '[')
                                {
                                    state = States.A13;
                                  

                                }
                                else
                                {
                                    if (symbol == ':')
                                    {
                                        state = States.A15;
                                      
                                    }
                                    else
                                    {





                                        state = States.E;
                                        error = "Ошибка ввода! Ожидался  символ пробел, '[', ':'";



                                    }
                                }
                            }
                            break;
                        }

                    case States.A13:
                        {
                            if (symbol == '0')
                            {
                                constant = symbol_number - 1;
                                constant_length++;

                                state = States.A19;
                                
                            }
                            else
                            {
                                if (symbol == '-')
                                {
                                    constant = symbol_number - 1;
                                    constant_length++;
                                    state = States.A16;
                                    
                                }
                                else
                                {
                                    if ((symbol == '1') || (symbol == '2') || (symbol == '3') || (symbol == '4') || (symbol == '5') || (symbol == '6') || (symbol == '7') || (symbol == '8') || (symbol == '9'))
                                    {
                                        constant = symbol_number - 1;
                                        constant_length++;
                                        state = States.A17;
                                        
                                    }
                                    else
                                    {
                                        if (symbol == ' ')
                                        {
                                            state = States.A13;
                                        }
                                        else
                                        {


                                            if ((char.IsLetter(symbol)) || (symbol == '_'))
                                            {
                                                id = symbol_number - 1;
                                                id_length++;
                                                state = States.A18;
                                                
                                                
                                            }
                                            


                                                    else
                                                    {
                                                        state = States.E;
                                                        error = "Ошибка ввода! Ожидался ввод букв от A до Z цифр от 0 до 9 или символов: пробел,'_' ,'-' ";
                                                    }
                                                
                                            
                                        }
                                    }
                                }
                            }
                            break;
                        }

                    case States.A16:
                        {
                            if ((symbol == '1') || (symbol == '2') || (symbol == '3') || (symbol == '4') || (symbol == '5') || (symbol == '6') || (symbol == '7') || (symbol == '8') || (symbol == '9'))
                            {
                                constant_length++;
                                state = States.A17;
                                
                            }
                            else
                            {
                                state = States.E;
                                error = "Ошибка ввода! Ожидался ввод  цифр от 1 до 9  ";
                            }
                            break;
                        }

                    case States.A17:
                        {
                            if (char.IsDigit(symbol))
                            {
                                constant_length++;
                                state = States.A17;
                               
                            }
                            
                            else
                            {
                                string Constants_string = str.Substring(constant, constant_length);
                                Constants.Add(Constants_string);
                                if (symbol == ']')
                                {
                                    state = States.A21;
                                    constant_length = 0;
                                }
                                else
                                {
                                    if (symbol == ' ')
                                    {
                                        state = States.A20;
                                        constant_length = 0;
                                    }

                                    else
                                    {


                                        state = States.E;
                                        error = "Ошибка ввода! Ожидался ввод цифр от 0 до 9 или символы пробел, ']'";



                                    }
                                    
                                }
                            }
                            break;
                        }

                    case States.A19:
                        {
                            
                            
                            string Constants_string = str.Substring(constant, constant_length);
                            Constants.Add(Constants_string);
                            id_length = 0;
                            if (symbol == ' ')
                            {
                                state = States.A19;
                            }
                            else
                            {
                                if (symbol == ']')
                                {
                                    state = States.A21;
                                }
                                else
                                {



                                    state = States.E;
                                    error = "Ошибка ввода! Ожидался ввод  пробелa, ']'";




                                }
                            }
                            break;
                        }

                    case States.A20:
                        {
                            if (symbol == ' ')
                            {
                                state = States.A20;
                            }
                            else
                            {
                                if (symbol == ']')
                                {
                                    state = States.A21;
                                }
                                else
                                {



                                    state = States.E;
                                    error = "Ошибка ввода! Ожидался ввод  пробелa, ']'";




                                }
                            }
                            break;
                        }
                    case States.A18:
                        {





                            if ((char.IsLetter(symbol)) || (symbol == '_') || (char.IsDigit(symbol)))
                            {
                                id_length++;
                                state = States.A18;
                            }
                            else
                            {
                                string ID_string = str.Substring(id, id_length);
                                if ((ID_string == "DO") || (ID_string == "WITH") || (ID_string == "DIV") || (ID_string == "MOD"))
                                {
                                    state = States.E;
                                    error = "Ошибка ввода! идентификатор не может быть зарезервированным словом.";
                                    symbol_number--;
                                }
                                else
                                {
                                    if (id_length > 8)
                                    {
                                        state = States.E;
                                        error = "Ошибка ввода! Длина символа не дложна превышать 8 знаков";
                                        symbol_number--;
                                    }
                                    else
                                    {
                                        ID.Add(ID_string);
                                        if (symbol == ' ')
                                        {
                                            state = States.A20;
                                            id_length = 0;
                                        }
                                        else
                                        {
                                            if (symbol == ']')
                                            {
                                                state = States.A21;
                                                id_length = 0;
                                            }


                                            else
                                            {
                                                state = States.E;
                                                error = "Ошибка ввода! Ожидался ввод букв от A до Z,чисел от 0 до 9 или символ пробел, '_', ']'";
                                            }
                                        }
                                       
                                    }
                                }
                            }
                            break;
                        }
                    case States.A21:
                        {
                            if (symbol == ' ')
                            {
                                state = States.A21;
                            }
                            else
                            {
                                if (symbol == ':')
                                {
                                    state = States.A15;
                                }
                                else
                                {
                                    state = States.E;
                                    error = "Ошибка ввода! Ожидался ввод ':'";
                                }
                            }
                            break;
                        }

                    case States.A15:
                        {

                            if (symbol == '=')
                            {
                                state = States.A22;
                            }
                            else
                            {
                                state = States.E;
                                error = "Ошибка ввода! Ожидался ввод '='";
                            }
                            break;
                        }

                    case States.A22:
                        {
                            if ((symbol == '1') || (symbol == '2') || (symbol == '3') || (symbol == '4') || (symbol == '5') || (symbol == '6') || (symbol == '7') || (symbol == '8') || (symbol == '9'))
                            {
                                constant = symbol_number - 1;
                                constant_length++;
                                state = States.A41;
                               
                            }
                            else
                            {
                                if (symbol == '0')
                                {
                                    constant = symbol_number - 1;
                                    constant_length++;
                                    state = States.A42;
                                    
                                }
                                else
                                {
                                    if (symbol == '-')
                                    {
                                        constant = symbol_number - 1;
                                        constant_length++;
                                        state = States.A40;
                                      
                                    }
                                    else
                                    {
                                        if(symbol == '\'')
                                        //if (char.GetNumericValue(symbol) == 39)
                                        {
                                            state = States.A36;
                                        }
                                        else
                                        {
                                            if (symbol == ' ')
                                            {
                                                state = States.A22;
                                            }
                                            else
                                            {


                                                if ((char.IsLetter(symbol)) || (symbol == '_'))
                                                {
                                                    id = symbol_number - 1;
                                                    id_length++;
                                                    state = States.A23;
                                                  
                                                }
                                                


                                                        else
                                                        {
                                                            state = States.E;
                                                            error = "Ошибка ввода! Ожидался ввод букв от A до Z цифр от 0 до 9 или символов: пробел, '_' ,'-'";
                                                        }
                                                    
                                                
                                            }
                                        }
                                    }
                                }
                            }
                            break;
                        }
                    case States.A23:
                        {



                            if ((char.IsLetter(symbol)) || (symbol == '_') || (char.IsDigit(symbol)))
                            {
                                id_length++;
                                state = States.A23;
                            }
                            else
                            {
                                string ID_string = str.Substring(id, id_length);
                                if ((ID_string == "DO") || (ID_string == "WITH") || (ID_string == "DIV") || (ID_string == "MOD"))
                                {
                                    state = States.E;
                                    error = "Ошибка ввода! идентификатор не может быть зарезервированным словом.";
                                    symbol_number--;
                                }
                                else
                                {
                                    if (id_length > 8)
                                    {
                                        state = States.E;
                                        error = "Ошибка ввода! Длина символа не дложна превышать 8 знаков";
                                        symbol_number--;
                                    }
                                    else
                                    {
                                        ID.Add(ID_string);
                                        if (symbol == ';')
                                        {
                                            state = States.A39;
                                            id_length = 0;
                                        }
                                        else
                                        {
                                            if (symbol == ' ')
                                            {
                                                state = States.A25;
                                                id_length = 0;
                                            }
                                            else
                                            {
                                                if (symbol == '[')
                                                {
                                                    state = States.A24;
                                                    id_length = 0;
                                                }
                                                else
                                                {
                                                    if ((symbol == '+') || (symbol == '-') || (symbol == '/') || (symbol == '*'))
                                                    {
                                                        state = States.A22;
                                                        id_length = 0;
                                                    }

                                                    else
                                                    {
                                                        state = States.E;
                                                        error = "Ошибка ввода! Ожидался ввод букв от A до Z,чисел от 0 до 9 или символ пробел, '_', ';', '['";
                                                    }
                                                }

                                            }
                                        }
                                    }
                                }
                            }
                            break;
                        }
                    case States.A25:
                        {
                            if (symbol == 'D')
                            {
                                state = States.A31;
                            }
                            else
                            {
                                if (symbol == 'M')
                                {
                                    state = States.A32;
                                }
                                else
                                {
                                    if (symbol == ' ')
                                    {
                                        state = States.A25;
                                    }
                                    else
                                    {
                                        if (symbol == '[')
                                        {
                                            state = States.A24;
                                        }
                                        else
                                        {
                                            if (symbol == ';')
                                            {
                                                state = States.A39;
                                            }
                                            else
                                            {
                                                if ((symbol == '+') || (symbol == '-') || (symbol == '/') || (symbol == '*'))
                                                {
                                                    state = States.A22;
                                                }
                                                else
                                                {

                                                    state = States.E;
                                                    error = "Ошибка ввода! Ожидался ввод  символов пробел, ';', '[', '[','M','D','+','-','/','*'.";
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            break;
                        }

                    case States.A24:
                        {
                            if (symbol == '0')
                            {
                                constant = symbol_number - 1;
                                constant_length++;
                                state = States.A27;
                               
                            }
                            else
                            {
                                if (symbol == '-')
                                {
                                    constant = symbol_number - 1;
                                    constant_length++;
                                    state = States.A28;
                                    
                                }
                                else
                                {
                                    if ((symbol == '1') || (symbol == '2') || (symbol == '3') || (symbol == '4') || (symbol == '5') || (symbol == '6') || (symbol == '7') || (symbol == '8') || (symbol == '9'))
                                    {
                                        constant = symbol_number - 1;
                                        constant_length++;
                                        state = States.A29;
                                       
                                    }
                                    else
                                    {
                                        if (symbol == ' ')
                                        {
                                            state = States.A24;
                                        }
                                        else
                                        {


                                            if ((char.IsLetter(symbol)) || (symbol == '_'))
                                            {
                                                id = symbol_number - 1;
                                                id_length++;
                                                state = States.A26;
                                             
                                               
                                            }
                                            


                                                    else
                                                    {
                                                        state = States.E;
                                                        error = "Ошибка ввода! Ожидался ввод букв от A до Z цифр от 0 до 9 или символов: пробел,'_' ,'-' ";
                                                    }
                                                
                                            
                                        }
                                    }
                                }
                            }
                            break;
                        }

                    case States.A28:
                        {
                            if ((symbol == '1') || (symbol == '2') || (symbol == '3') || (symbol == '4') || (symbol == '5') || (symbol == '6') || (symbol == '7') || (symbol == '8') || (symbol == '9'))
                            {
                                constant_length++;
                                state = States.A29;
                               
                            }
                            else
                            {
                                state = States.E;
                                error = "Ошибка ввода! Ожидался ввод  цифр от 1 до 9  ";
                            }
                            break;
                        }

                    case States.A29:
                        {
                            if (char.IsDigit(symbol))
                            {
                                constant_length++;
                                state = States.A29;
                                
                            }
                            
                            else
                            {
                                string Constants_string = str.Substring(constant, constant_length);
                                Constants.Add(Constants_string);
                                if (symbol == ']')
                                {
                                    state = States.A30;
                                    constant_length = 0;
                                }
                                else
                                {
                                    if (symbol == ' ')
                                    {
                                        state = States.A50;
                                        constant_length = 0;
                                    }

                                    else
                                    {


                                        state = States.E;
                                        error = "Ошибка ввода! Ожидался ввод цифр от 0 до 9 или символы пробел, ']'";



                                    }
                                }
                            }
                            break;
                        }

                    case States.A27:
                        {
                           
                            string Constants_string = str.Substring(constant, constant_length);
                            Constants.Add(Constants_string);
                            if (symbol == ' ')
                            {
                                state = States.A27;
                            }
                            else
                            {
                                if (symbol == ']')
                                {
                                    state = States.A30;
                                }
                                else
                                {



                                    state = States.E;
                                    error = "Ошибка ввода! Ожидался ввод  пробелa, ']'";




                                }
                            }
                            break;
                        }

                    case States.A50:
                        {
                            if (symbol == ' ')
                            {
                                state = States.A50;
                            }
                            else
                            {
                                if (symbol == ']')
                                {
                                    state = States.A30;
                                }
                                else
                                {



                                    state = States.E;
                                    error = "Ошибка ввода! Ожидался ввод  пробелa, ']'";




                                }
                            }
                            break;
                        }
                    case States.A26:
                        {





                            if ((char.IsLetter(symbol)) || (symbol == '_') || (char.IsDigit(symbol)))
                            {
                                id_length++;
                                state = States.A18;
                            }
                            else
                            {
                                string ID_string = str.Substring(id, id_length);
                                if ((ID_string == "DO") || (ID_string == "WITH") || (ID_string == "DIV") || (ID_string == "MOD"))
                                {
                                    state = States.E;
                                    error = "Ошибка ввода! идентификатор не может быть зарезервированным словом.";
                                    symbol_number--;
                                }
                                else
                                {
                                    if (id_length > 8)
                                    {
                                        state = States.E;
                                        error = "Ошибка ввода! Длина символа не дложна превышать 8 знаков";
                                        symbol_number--;
                                    }

                                    else
                                    {
                                        ID.Add(ID_string);
                                        if (symbol == ' ')
                                        {
                                            state = States.A50;
                                            id_length = 0;
                                        }
                                        else
                                        {
                                            if (symbol == ']')
                                            {
                                                state = States.A30;
                                                id_length = 0;
                                            }
                                            else
                                            {
                                                state = States.E;
                                                error = "Ошибка ввода! Ожидался ввод букв от A до Z,чисел от 0 до 9 или символ пробел, '_', ']'";
                                            }
                                        }

                                    }
                                }
                            }
                            break;
                        }

                    case States.A30:
                        {

                            if (symbol == ' ')
                            {
                                state = States.A30;
                            }
                            else
                            {
                                if (symbol == 'M')
                                {
                                    state = States.A32;
                                }
                                else
                                {
                                    if (symbol == 'D')
                                    {
                                        state = States.A31;
                                    }
                                    else
                                    {
                                        if (symbol == ';')
                                        {
                                            state = States.A39;
                                        }
                                        else
                                        {
                                            if ((symbol == '+') || (symbol == '-') || (symbol == '/') || (symbol == '*'))
                                            {

                                                state = States.A22;
                                            }
                                            else
                                            {
                                                state = States.E;
                                                error = "Ошибка ввода! Ожидался ввод  символов пробел, ';', 'M', 'D', '+', '/', '*', '-'";
                                            }


                                        }


                                    }
                                }
                            }
                            break;
                        }

                    case States.A36:
                        {
                            if((char.IsSymbol(symbol))||(char.IsLetterOrDigit(symbol)))
                            //if ((char.GetNumericValue(symbol) >= 0) || (char.GetNumericValue(symbol) >= 256))
                            {
                                state = States.A37;
                            }
                            else
                            {


                                state = States.E;
                                error = "Ошибка ввода! Ожидался ввод текста";



                            }
                            break;
                        }

                    case States.A37:
                        {
                            if(symbol == '\'')
                            //if (char.GetNumericValue(symbol) == 39)
                            {
                                state = States.A38;
                            }
                            else
                            {
                                if ((char.IsSymbol(symbol)) || (char.IsLetterOrDigit(symbol)))
                                //if ((char.GetNumericValue(symbol) >= 0) || (char.GetNumericValue(symbol) >= 256))
                                {
                                    state = States.A37;
                                }
                                else
                                {


                                    state = States.E;
                                    error = "Ошибка ввода! Ожидался ввод текста или ' ";



                                }
                            }
                            break;
                        }

                    case States.A38:
                        {
                            if (symbol == ';')
                            {
                                state = States.A39;
                            }
                            else
                            {
                                if (symbol == ' ')
                                {
                                    state = States.A38;
                                }
                                else
                                {


                                    state = States.E;
                                    error = "Ошибка ввода! Ожидался ввод символа ';'";



                                }
                            }
                            break;

                        }


                    case States.A40:
                        {
                            if (symbol == '0')
                            {
                                constant_length++;
                                state = States.A43;
                                
                            }
                            else
                            {
                                if ((symbol == '1') || (symbol == '2') || (symbol == '3') || (symbol == '4') || (symbol == '5') || (symbol == '6') || (symbol == '7') || (symbol == '8') || (symbol == '9'))
                                {
                                    constant_length++;
                                    state = States.A41;
                                    
                                }
                                else
                                {


                                    state = States.E;
                                    error = "Ошибка ввода! Ожидался ввод цифр от 0 до 9";



                                }
                            }
                            break;

                        }

                    case States.A43:
                        {
                            if (symbol == '.')
                            {
                                constant_length++;
                                state = States.A44;
                                
                            }
                            else
                            {



                                state = States.E;
                                error = "Ошибка ввода! Ожидался ввод символа '.'";




                            }
                            break;

                        }

                    case States.A41:
                        {
                            if (char.IsDigit(symbol))
                            {
                                constant_length++;
                                state = States.A41;
                                
                            }
                            
                            else
                            {
                                
                                if (symbol == '.')
                                {
                                    constant_length++;
                                    state = States.A44;

                                }
                                

                                else
                                {
                                    string Constants_string = str.Substring(constant, constant_length);
                                    Constants.Add(Constants_string);
                                    if (symbol == ' ')
                                    {
                                        state = States.A45;
                                        constant_length = 0;
                                    }
                                    else
                                    {
                                        if (symbol == ';')
                                        {
                                            state = States.A39;
                                            constant_length = 0;
                                        }

                                        else
                                        {
                                            if ((symbol == '+') || (symbol == '-') || (symbol == '/') || (symbol == '*'))
                                            {
                                                state = States.A22;
                                                constant_length = 0;
                                            }
                                            else
                                            {


                                                state = States.E;
                                                error = "Ошибка ввода! Ожидался ввод цифр от 0 до 9 пробела и символов ';','.','+','-','/','*'.";



                                            }
                                        }
                                    }
                                }
                            }
                            break;

                        }

                    case States.A45:
                        {
                            if (symbol == ';')
                            {
                                state = States.A39;
                            }
                            else
                            {
                                if (symbol == 'M')
                                {
                                    state = States.A32;
                                }
                                else
                                {
                                    if (symbol == ' ')
                                    {
                                        state = States.A45;
                                    }
                                    else
                                    {
                                        if (symbol == 'D')
                                        {
                                            state = States.A31;
                                        }
                                        else
                                        {
                                            if ((symbol == '+') || (symbol == '-') || (symbol == '/') || (symbol == '*'))
                                            {
                                                state = States.A22;
                                            }
                                            else
                                            {


                                                state = States.E;
                                                error = "Ошибка ввода! Ожидался ввод пробела и символов ';','M','+','-','/','*','D'.";



                                            }
                                        }
                                    }
                                }
                            }
                            break;

                        }

                    case States.A42:
                        {
                            if (symbol == '.')
                            {
                                constant_length++;
                                state = States.A44;

                            }
                           
                            else
                            {
                                string Constants_string = str.Substring(constant, constant_length);
                                Constants.Add(Constants_string);

                                if (symbol == ' ')
                                {
                                    state = States.A45;
                                    constant_length = 0;
                                }
                                else
                                {
                                    if (symbol == ';')
                                    {
                                        state = States.A39;
                                        constant_length = 0;
                                    }

                                    else
                                    {
                                        if ((symbol == '+') || (symbol == '-') || (symbol == '/') || (symbol == '*'))
                                        {
                                            state = States.A22;
                                            constant_length = 0;
                                        }
                                        else
                                        {


                                            state = States.E;
                                            error = "Ошибка ввода! Ожидался ввод  пробела и символов ';','.','+','-','/','*'.";



                                        }
                                    }
                                }

                            }
                            break;

                        }

                    case States.A44:
                        {
                            if (char.IsDigit(symbol))
                            {
                                constant_length++;
                                state = States.A46;
                                
                            }
                            else
                            {

                                state = States.E;
                                error = "Ошибка ввода! Ожидался ввод цифр от 0 до 9 ";





                            }
                            break;
                        }

                    case States.A46:
                        {
                            if (char.IsDigit(symbol))
                            {
                                constant_length++;
                                state = States.A46;
                                
                            }
                           
                            else
                            {
                                if (symbol == 'E')
                                {
                                    constant_length++;
                                    state = States.A47;

                                }
                                

                                else
                                {
                                    string Constants_string = str.Substring(constant, constant_length);
                                    Constants.Add(Constants_string);
                                    if (symbol == ' ')
                                    {
                                        state = States.A45;
                                        constant_length = 0;
                                    }
                                    else
                                    {
                                        if (symbol == ';')
                                        {
                                            state = States.A39;
                                            constant_length = 0;
                                        }

                                        else
                                        {
                                            if ((symbol == '+') || (symbol == '-') || (symbol == '/') || (symbol == '*'))
                                            {
                                                state = States.A22;
                                                constant_length = 0;
                                            }
                                            else
                                            {


                                                state = States.E;
                                                error = "Ошибка ввода! Ожидался ввод цифр от 0 до 9 пробела и символов ';','.','+','-','/','*','E'.";



                                            }
                                        }
                                    }
                                }
                            }
                            break;

                        }

                    case States.A47:
                        {
                            if ((symbol == '-') || (symbol == '+'))
                            {
                                constant_length++;
                                state = States.A48;
                                
                            }
                            else
                            {
                                if (char.IsDigit(symbol))
                                {
                                    constant_length++;
                                    state = States.A49;
                                    
                                }
                                else
                                {



                                    state = States.E;
                                    error = "Ошибка ввода! Ожидался ввод цифр от 0 до 9  и символов '+','-'.";






                                }
                            }
                            break;

                        }
                    case States.A48:
                        {
                            if (char.IsDigit(symbol))
                            {
                                constant_length++;
                                state = States.A49;
                                
                            }
                            else
                            {



                                state = States.E;
                                error = "Ошибка ввода! Ожидался ввод цифр от 0 до 9 ";






                            }
                            break;
                        }

                    case States.A49:
                        {
                            if (char.IsDigit(symbol))
                            {
                                constant_length++;
                                state = States.A49;

                            }
                                else
                                {
                                    string Constants_string = str.Substring(constant, constant_length);
                                    Constants.Add(Constants_string);
                                    if (symbol == ' ')
                                    {
                                        state = States.A45;
                                        constant_length = 0;
                                    }
                                    else
                                    {
                                        if (symbol == ';')
                                        {
                                            state = States.A39;
                                            constant_length = 0;
                                        }

                                        else
                                        {
                                            if ((symbol == '+') || (symbol == '-') || (symbol == '/') || (symbol == '*'))
                                            {
                                                state = States.A22;
                                                constant_length = 0;
                                            }
                                            else
                                            {


                                                state = States.E;
                                                error = "Ошибка ввода! Ожидался ввод цифр от 0 до 9 пробела и символов ';','.','+','-','/','*'.";



                                            }
                                        }
                                    }
                                }


                            break;
                        }

                    case States.A39:
                        {
                            state = States.F;
                            
                        }
                        break;
                }
                if (state == States.A39)
                {
                    res = "Успех";
                }
            }
            
        }
    }
}


                                    


                                

                                            
            
        
    

