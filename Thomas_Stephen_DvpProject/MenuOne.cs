using System;
namespace Thomas_Stephen_DvpProject
{
    public class MenuOne
    {
        //Menu 
        //Swap Name
        //Backwords;
        //Age Coverter
        //Temp Converter


       
        string mSwapName;
        string mBackwards;
        string mAgeConvert;
        string mTempConvert;
        string mBigBlueFish;
        string mExit;

        public MenuOne(string _swapName, string _backwords, string _ageConvert, string _tempConvert, string _bigBlueFish,string _exit)
        {
            mSwapName = _swapName;
            mBackwards = _backwords;
            mAgeConvert = _ageConvert;
            mTempConvert = _tempConvert;
            mBigBlueFish = _bigBlueFish;
            mExit = _exit;

        }

        public string getSwapName()
        {
            return mSwapName;
        }


        public void setSwapName(string _swapName)
        {

            mSwapName = _swapName;



        }


        public string getBackwards()
        {
            return mBackwards;
        }


        public void setBackwards(string _backwards)
        {

            mBackwards = _backwards;



        }
        public string getAgeConvet()
        {
            return mAgeConvert;
        }


        public void setAgeconvert(string _ageConvert)
        {

            mAgeConvert = _ageConvert;



        }
        public string getTempConvert()
        {
            return mTempConvert;
        }


        public void setTempConvert(string _tempConvert)
        {

            mTempConvert = _tempConvert;



        }
        public string getBigBlueFish()
        {
            return mBigBlueFish;
        }


        public void setBigBlueFish(string _bigBlueFish)
        {

            mBigBlueFish = _bigBlueFish;



        }
        public string getExit()
        {
            return mExit;
        }
        public void setExit(string _exit)
        {
            mExit = _exit;


        }










    }
}
