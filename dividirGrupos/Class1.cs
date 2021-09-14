using System;

namespace dividirGrupos
{
    public class GrupDiv
    {

        public static string Input_Validator(string? input){
            if(String.IsNullOrEmpty(input)){
                throw new Exception();
            }
            return "hello world";
        }
    }
}
