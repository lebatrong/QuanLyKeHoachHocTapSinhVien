use Master

select * from Note where MSSV='15004116'
select * from diem where MSSV='15004116'

update Diem set MaMon='DT1229' where MaMon='DT1221' and MSSV='15004116'
insert into Note values('1',N'cccc',N'xxx',Convert(datetime,'13/09/2017',103),Convert(datetime,'13/09/2017',103),0)
SELECT Id, TieuDe, NgayLap FROM Note where MSSV='15004116' AND abs(datediff(day,NgayThongBao,getdate()))<=3 and LanThongBao=0
select * from Note

delete from Note where MSSV='1' and LanThongBao=1 and abs(datediff(day,NgayThongBao,getdate()))=0

update MonHoc set MaMon='DT1221', TenMon=N'Kỹ thuật số', SoTinChi=3 where MaMon='DT1229'

select * from Note where MSSV='15004116' AND abs(datediff(day,NgayThongBao,getdate()))<=3 and LanThongBao=1
update Note set LanThongBao=0 where MSSV='15004116' AND abs(datediff(day,NgayThongBao,getdate()))<=3 and LanThongBao=1
select * from Note where MSSV='15004116' order by NgayLap desc


ALTER TABLE MonHoc NOCHECK CONSTRAINT ALL


ALTER TABLE MonHoc WITH CHECK CHECK CONSTRAINT ALL
ALTER TABLE Diem WITH CHECK CHECK CONSTRAINT ALL
ALTER TABLE SinhVien WITH CHECK CHECK CONSTRAINT ALL

CREATE TRIGGER UpdateOfMonHoc
ON MonHoc
FOR UPDATE
AS
BEGIN
	
		ALTER TABLE MonHoc NOCHECK CONSTRAINT ALL
		update MonHoc
			 set MonHoc.MaMon=inserted.MaMon, 
				MonHoc.TenMon=inserted.TenMon,
				MonHoc.SoTinChi=inserted.SoTinChi
			where deleted.MaMon=inserted.MaMon 
		ALTER TABLE MonHoc WITH CHECK CHECK CONSTRAINT ALL
	
END
	