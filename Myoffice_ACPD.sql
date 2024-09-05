
CREATE TABLE Myoffice_ACPD (
    acpd_sid NVARCHAR(20) PRIMARY KEY,           -- �ϥΪ̥D��A�ѹw�s�{�ǥͦ�
    acpd_cname NVARCHAR(60) NOT NULL,            -- ����W��
    acpd_ename NVARCHAR(40),                     -- �^��W��
    acpd_sname NVARCHAR(40),                     -- ²��
    acpd_email NVARCHAR(60),                     -- �ϥΪ̫H�c
    acpd_status TINYINT NOT NULL,                -- ���p: 0=���`, 99=�����`
    acpd_stop BIT NOT NULL,                      -- �O�_����/���i�n�J
    acpd_stopMemo NVARCHAR(600),                 -- ���έ�]
    acpd_LoginID NVARCHAR(30) NOT NULL,          -- �n�J�b��
    acpd_LoginPW NVARCHAR(60) NOT NULL,          -- �n�J�K�X
    acpd_memo NVARCHAR(120),                     -- �Ƶ�
    acpd_nowdatetime DATETIME DEFAULT GETDATE(), -- �s�W���
    appd_nowid NVARCHAR(20),                     -- �s�W�H���N�X
    acpd_upddatetime DATETIME,                   -- �ק���
    acpd_updid NVARCHAR(20)                      -- �ק�H���N�X
);