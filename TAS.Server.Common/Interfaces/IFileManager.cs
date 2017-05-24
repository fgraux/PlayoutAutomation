﻿using System;
using System.Collections.Generic;

namespace TAS.Server.Common.Interfaces
{
    public interface IFileManager
    {
        IEnumerable<IFileOperation> GetOperationQueue();
        IConvertOperation CreateConvertOperation();
        ILoudnessOperation CreateLoudnessOperation();
        IFileOperation CreateSimpleOperation();
        event EventHandler<FileOperationEventArgs> OperationAdded;
        event EventHandler<FileOperationEventArgs> OperationCompleted;
        void QueueList(IEnumerable<IFileOperation> operationList, bool toTop);
        void Queue(IFileOperation operation, bool toTop);
        void CancelPending();
    }
}
