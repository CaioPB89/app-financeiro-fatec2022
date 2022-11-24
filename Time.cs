using System;
using System.Collections.Generic;
using Jog;
using Tec;


namespace Tim
{
    public class Time
    {
        public Time(string ntime,string local,int placar,List<Jogador> jognotime,Tecnico tecin)
        {
            NTime=ntime;
            Local=local;
            Placar=placar;
            JogNoTime=jognotime;
            Tecin=tecin;
            
        }
        public string? NTime{get;private set;}
        public string? Local{get;private set;}
        public int Placar{get;private set;}
        public List<Jogador> JogNoTime{get;private set;}
        public Tecnico Tecin{get;private set;}
        
    }
}