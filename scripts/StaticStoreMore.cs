using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

// usage: DMT.StaticStore.myData = ...


namespace DMT
{
    public static class StaticStoreMore
    {
        
        private static int _myRoundShort = 0;

        public static int myRoundShort {  
            get { return _myRoundShort; }
            set { _myRoundShort = value; }
        }

        // #####################################################
        
        private static int _myRoundVeryShort = 0;
        public static int myRoundVeryShort
        {
            get => _myRoundVeryShort;
            set => _myRoundVeryShort = value;
        }

        // #####################################################

        private static int _myRound = 0;
        public static int myRound
        {
            get { return _myRound; }

            set
            {
                int gotData = value;
                if ((gotData >= 0) && (gotData <= 100))
                {
                    _myRound = value;
                }
                else
                {
                    UnityEngine.Debug.LogWarning("setter warning for DMT.StaticStore _myRound");
                }
            }
        }
    }

}
