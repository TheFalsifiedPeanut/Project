namespace Collect_Dudes.World.DataPools
{
    using Data.General;
    using System.Collections.Generic;

    internal abstract class DataPool<T> where T : IIdentifier
    {
        static protected DataPool<T> dataPool;
        protected List<T> data;

        #region Getters
        public static int GetDataCount()
        {
            return dataPool.data.Count;
        }

        public static T GetDataByIndex(int index)
        {
            if (dataPool.data.Count > index)
            {
                return dataPool.data[index];
            }
            return default;
        }

        public static T GetDataByID(ushort id)
        {
            for (int i = 0; i < dataPool.data.Count; i++)
            {
                if (dataPool.data[i].id == id)
                {
                    return dataPool.data[i];
                }
            }
            return default;
        }

        public static List<T> GetData()
        {
            return dataPool.data;
        }
        #endregion

        public DataPool()
        {
            data = new List<T>();
        }
        
        public static ushort FindFirstFreeID()
        {
            bool takenID = false;
            for (ushort i = 0; i < ushort.MaxValue; i++)
            {
                for (int j = 0; j < dataPool.data.Count; j++)
                {
                    if (i == dataPool.data[j].id)
                    {
                        takenID = true;
                        break;
                    }
                }
                if (takenID)
                {
                    takenID = false;
                }
                else
                {
                    return i;
                }
            }
            return 0;
        }
    }
}