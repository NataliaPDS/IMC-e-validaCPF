using System;
using System.ComponentModel;
using System.Dynamic;
using System.Windows.Forms;

public class Validacoes
{ 
    public static bool ValidaCPF(string cpf)
    {
        //alteração para verificar git ou github
        //primeira parte - tirar pontos e traços
        cpf = cpf.Replace(".", "");//remove ponto do cpf
        cpf = cpf.Replace("-", "");

        
        int cont = 10;
        int cont1 = 11;
        int soma = 0;//cont
        int soma1 = 0;
     
        //verificar se tem 11 digitos
        if (cpf.Length == 11)
        {
           
                                                                                                                                                                        //cpf = 053664391175 soma = 191
            //1111
            for (int i = 0; i < cpf.Length - 2; i++)// 1 ate 10
            {
                soma += Convert.ToInt32(cpf[i].ToString()) * cont;
                cont = cont - 1;
               
            }
            MessageBox.Show(soma.ToString());
            int rest = soma % 11;
            
            if (rest < 2)
            {
                rest = 0;
            }
            else// if (rest >= 2)
            {
                rest = 11 - rest;
            }

            if (Convert.ToInt32(cpf[9].ToString()) != rest)
            {
                return false;
            }
          

            //222
            for (int i = 0; i < cpf.Length - 1; i++)// 1 ate 11
            {
                soma1 = Convert.ToInt32(cpf[i].ToString()) * cont1; 
                
                cont1 = cont1 - 1;
            }
            int rest1 = soma1 % 11;
            
            if (rest1 < 2)
            {
                rest1 = 0;
            }
            else //rest1 >= 2
            {
                rest1 = 11 - rest1;
            }

            if (Convert.ToInt32(cpf[10].ToString()) != rest1)//se o cpf da resto diferente la de cima
            {
               return false;
            }
           
            return true;
        }
        else
        {
            return false;   
        }
       
      
    }


}

