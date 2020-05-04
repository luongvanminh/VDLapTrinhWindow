USE QLQuan;
SELECT * 
From HDChiTietDatHang hdct
INNER JOIN ThucUong thucUong 
            ON hdct.MSHH = thucUong.MSHH
Where MSDH='DH0001'