using System;
using System.Collections.Generic;
using System.Linq;

public class Vettore
{
    private int[] vettore;
    private int idx = 0;

    public Vettore()
    {

        vettore = new int[] { 0 };
    }
    //costruisci con parametro N
    public Vettore(int N)
    {
        if (N <= 0)
            vettore = new int[0];
        else
            vettore = new int[N];

    }
    public bool Aggiungi(int val)
    {
        if (vettore.Length <= idx)
            return false;

        vettore[idx] = val;
        idx++;

        return true;
    }



    public int Somma()
    {

        int retVal = 0;
        for (int idx = 0; idx < vettore.Length; idx++)
        {
            retVal += vettore[idx];
        }
        return retVal;
    }
    
    public int Ultimo()
    {
        if(vettore.Length == 0)
            return 0;
        
        if (idx == 0)
            return vettore[idx];

        return vettore[idx - 1];
    }

    public bool EliminaUltimo()
    {
        if(vettore.Length == 0)
            return false;
        
        if (idx == 0)
            if(vettore[idx] == 0)
                return false;
        else
            vettore[idx-1] = 0;
        
        return true;
    }


}