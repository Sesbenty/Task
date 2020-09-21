using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Input;

namespace Task
{
    class LoopProject
    {
        private Project  _project;

        public bool Running { get; private set; }

        public void Load(Project obj)
        {
            _project = obj;
        }

        public async void Start()
        {
            if (_project == null)
                throw new ArgumentException("Not load");

           
            _project.Load();

            Running = true;

            DateTime _previousGameTime = DateTime.Now;

            while (Running)
            {
              
                TimeSpan GameTime = DateTime.Now - _previousGameTime;
                
                _previousGameTime = _previousGameTime + GameTime;
                
                _project.Update(GameTime);
                
                
                await System.Threading.Tasks.Task.Delay(8);
            }
        }

        public void Stop()
        {
            Running = false;
            _project?.Unload();
        }
      
        public void Draw(Graphics gfx)
        {
            _project.Draw(gfx);
        }
    }
}
