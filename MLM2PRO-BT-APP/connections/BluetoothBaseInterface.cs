﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLM2PRO_BT_APP.connections
{
    public interface IBluetoothBaseInterface
    {
        public abstract bool IsBluetoothDeviceValid();
        public abstract Task ArmDevice();
        public abstract byte[]? ConvertAuthRequest(byte[]? input);
        public abstract Task DisarmDevice();
        public abstract Task RestartDeviceWatcher();
        public abstract Task DisconnectAndCleanup();
        public abstract byte[]? GetEncryptionKey();
        public abstract Task UnSubAndReSub();
    }
}
