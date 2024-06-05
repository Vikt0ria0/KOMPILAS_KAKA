using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WindowsFormsApp2.State;

namespace WindowsFormsApp2
{
    public class State
    {
        public List<StateState> state;
        public List<Type> type;
        public enum StateState
        {
            None = 0,
            F,
            I,
            M,
            A,
            N,
            Q,
            S,
            U,
            T,
            V,
            L,
            H,
            C,
            Ъ,
            K,
            D,
            O, 
            J,
            B,
            W,
            END
        };

        public enum Type
        {
            None = 0,
            F,
            I,
            M,
            A,
            N,
            Q,
            S,
            U,
            T,
            V,
            L,
            H,
            C,
            Ъ,
            K,
            D,
            O,
            J,
            B,
            W,
            END
        };

    }

    public class Parser
    {
        public State magasin = new State();     

        Parser() 
        {
            magasin.state.Add(StateState.F);
        }

        public List<string> Stroka = new List<string> { "int", "a", ":=", "5", ";", "\n", "a", "=", "a", "+", "5", ";", "END" };
        int i= 0;
        public string Lex()
        {
            return Stroka[i];
        }

        public void Ops()
        {
            while (Lex() != "END" && magasin.state[0] != StateState.END)
            {
                i++;

                StateState stateLex = magasin.state[0];
                magasin.state.Remove(0);

                //
            }
        }

        //public void Pair(State stateLex)
        //{
        //      if(stateLex.state[0] == F && stateLex.type[0] == NAME)
        //
        //}
    }
}
