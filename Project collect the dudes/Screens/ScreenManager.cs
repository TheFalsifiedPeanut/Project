using System;
using System.Collections.Generic;
using System.Text;

namespace Collect_Dudes.Screens
{

    class ScreenManager
    {
        #region Variables
        static ScreenManager screenManager;
        Queue<Screen> screens;
        #endregion
        #region Getters
        public static ScreenManager GetScreenManager()
        {
            return screenManager;
        }
        #endregion
        #region Enqueuing
        public void EnqueueScreen(Screen screen)
        {
            screens.Enqueue(screen);
        }
        #endregion
        #region Dequeuing
        public Screen DequeueScreen()
        {
            return screens.Dequeue();
        }
        #endregion
        public ScreenManager()
        {
            if (screenManager == null)
            {
                screenManager = this;
                
            }
            screens = new Queue<Screen>();
        }
        public void RenderNextScreen()
        {
            screens.Dequeue().Render();
        }
    }

}
