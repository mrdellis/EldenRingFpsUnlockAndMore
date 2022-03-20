using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpDX.Direct3D;
using SharpDX.DXGI;

namespace EldenRingFPSUnlockAndMore
{

    using SharpDX;
    using SharpDX.Direct3D12;
    using SharpDX.Windows;

    public class DirectX : IDisposable
    {
        public Process GameProcess =  null;


        private Device _device = null;
        private Process _gameProcess;

        public DirectX(Process GameProcess)
        {

            #if DEBUG
            {
                DebugInterface.Get().EnableDebugLayer();
            }
            #endif

            _gameProcess = GameProcess;

            _device = Device.FromPointer<Device>(_gameProcess.MainWindowHandle.ToInt64());
            //Initialize();
        }

        private void Initialize()
        {
            _device = new Device(null, FeatureLevel.Level_11_1);
            
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
