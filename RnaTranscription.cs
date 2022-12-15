using System;
using System.Collections.Generic;
using System.Text;

public static class TrascrizioneRNA
{
    public static string ToRna(string dna)
    {
        string rna="";
        char a = 'A';
        char g = 'G';
        char c = 'C';
        char t = 'T';
        for(int i=0; i<dna.Length; i++)
        {     
            if( String.IsNullOrEmpty( dna ) )
            {
                return "";
            }
            else
            {
              
                if(dna[i]==g)
                {
                    rna = rna+"C";
                }
                if(dna[i]==c)
                {
                    rna = rna+"G";
                }
                if(dna[i]==t)
                {   
                    rna = rna+"A";
                } 
                if(dna[i]==a)
                {
                    rna = rna+"U";
                }
                
            }
            
        }
         

        return rna;
    }
}