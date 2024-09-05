CREATE TABLE Myoffice_ExcuteionLog
(
    DeLog_AuthID INT IDENTITY(1,1) PRIMARY KEY,              -- �ۭq���޽X
    DeLog_StoredPrograms NVARCHAR(120) NOT NULL,        -- �w�s�{�ǦW��
    DeLog_GroupID UNIQUEIDENTIFIER NOT NULL,            -- ���檺�s�եN�X (�ϥ� UNIQUEIDENTIFIER ���N un)
    DeLog_isCustomDebug BIT NOT NULL,                    -- �O�_�{�w�� Bug
    DeLog_ExecutionProgram NVARCHAR(120) NOT NULL,       -- ���檺����
    DeLog_ExecuteionInfo NVARCHAR(MAX),                  -- ���檺���e�άO����
    DeLog_VerifyNeeded BIT NOT NULL,                     -- �����~�O�_�n�i���ˬd
    exelog_nowdatetime DATETIME DEFAULT GETDATE()        -- �s�W���
);