CREATE TABLE Myoffice_ExcuteionLog
(
    DeLog_AuthID INT IDENTITY(1,1) PRIMARY KEY,              -- 自訂索引碼
    DeLog_StoredPrograms NVARCHAR(120) NOT NULL,        -- 預存程序名稱
    DeLog_GroupID UNIQUEIDENTIFIER NOT NULL,            -- 執行的群組代碼 (使用 UNIQUEIDENTIFIER 取代 un)
    DeLog_isCustomDebug BIT NOT NULL,                    -- 是否認定為 Bug
    DeLog_ExecutionProgram NVARCHAR(120) NOT NULL,       -- 執行的項目
    DeLog_ExecuteionInfo NVARCHAR(MAX),                  -- 執行的內容或是說明
    DeLog_VerifyNeeded BIT NOT NULL,                     -- 此錯誤是否要進行檢查
    exelog_nowdatetime DATETIME DEFAULT GETDATE()        -- 新增日期
);