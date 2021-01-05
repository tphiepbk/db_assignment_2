CREATE TABLE Dangkithe(
    Makhachhang	varchar(10) primary key NOT NULL,
    Machinhanh  char(6) not null,
	Ngaydangki  date NOT NULL,
	FOREIGN KEY (Makhachhang) REFERENCES Khachhang(Makhachhang),
	FOREIGN KEY (Machinhanh) REFERENCES Chinhanh(Machinhanh)
); 	




INSERT INTO Dangkithe (Makhachhang, Machinhanh, Ngaydangki)
VALUES ('CN1001', 'DN100', '2020-09-15');

INSERT INTO Dangkithe (Makhachhang, Machinhanh, Ngaydangki)
VALUES ('PN1002','DN100', '2020-12-15' );
INSERT INTO Dangkithe (Makhachhang, Machinhanh, Ngaydangki)
VALUES ('CV1003','DN101', '2020-12-07'  );
INSERT INTO Dangkithe (Makhachhang, Machinhanh, Ngaydangki)
VALUES ('PN1004', 'DN101', '2020-10-17' );
INSERT INTO Dangkithe (Makhachhang, Machinhanh, Ngaydangki)
VALUES ('PV1005', 'HN101','2020-10-17');
INSERT INTO Dangkithe(Makhachhang, Machinhanh, Ngaydangki)
VALUES ('CN1006','HCM100', '2020-01-27');
INSERT INTO Dangkithe (Makhachhang, Machinhanh, Ngaydangki)
VALUES ('PV1007', 'HN101', '2020-11-09' );
INSERT INTO Dangkithe (Makhachhang, Machinhanh, Ngaydangki)
VALUES ('PN1008', 'HN101', '2020-05-28');
INSERT INTO Dangkithe (Makhachhang, Machinhanh, Ngaydangki)
VALUES ('CV1009', 'HCM101' ,'2020-01-22');
INSERT INTO Dangkithe(Makhachhang, Machinhanh, Ngaydangki)
VALUES ('PV1010', 'HCM102','2020-02-18');
INSERT INTO Dangkithe (Makhachhang, Machinhanh, Ngaydangki)
VALUES ('PN1011','HN100','2020-01-11' );
INSERT INTO Dangkithe (Makhachhang, Machinhanh, Ngaydangki)
VALUES ('PV1012','DN101' , '2020-12-15');
INSERT INTO Dangkithe (Makhachhang, Machinhanh, Ngaydangki)
VALUES ('PN1013', 'HN101', '2020-08-11');
INSERT INTO Dangkithe(Makhachhang, Machinhanh, Ngaydangki)
VALUES ('CN1014', 'HN100','2020-01-27');
INSERT INTO Dangkithe (Makhachhang, Machinhanh, Ngaydangki)
VALUES ('PV1015', 'HN100','2020-01-11');
INSERT INTO Dangkithe(Makhachhang, Machinhanh, Ngaydangki)
VALUES ('PV1016', 'HCM102', '2020-09-12');
INSERT INTO Dangkithe(Makhachhang, Machinhanh, Ngaydangki)
VALUES ('CV1017', 'DN101', '2020-09-17');
INSERT INTO Dangkithe(Makhachhang, Machinhanh, Ngaydangki)
VALUES ('PN1018','HCM101','2020-01-27');
INSERT INTO Dangkithe(Makhachhang, Machinhanh, Ngaydangki)
VALUES ('CN1019', 'HN101', '2020-01-27');
INSERT INTO Dangkithe(Makhachhang, Machinhanh, Ngaydangki)
VALUES ('CV1020', 'HN101','2020-03-03');
INSERT INTO Dangkithe(Makhachhang, Machinhanh, Ngaydangki)
VALUES ('PN1021', 'HN101', '2020-01-11');
INSERT INTO Dangkithe(Makhachhang, Machinhanh, Ngaydangki)
VALUES ('PN1022','HCM101','2020-03-04' );
INSERT INTO Dangkithe(Makhachhang, Machinhanh, Ngaydangki)
VALUES ('CN1023', 'HN101', '2020-03-11' );
INSERT INTO Dangkithe(Makhachhang, Machinhanh, Ngaydangki)
VALUES ('PV1024','HN100', '2020-04-15');
INSERT INTO Dangkithe(Makhachhang, Machinhanh, Ngaydangki)
VALUES ('CV1025', 'DN100', '2020-04-15');
INSERT INTO Dangkithe(Makhachhang, Machinhanh, Ngaydangki)
VALUES ('PV1026','HN100', '2020-04-16');
INSERT INTO Dangkithe(Makhachhang, Machinhanh, Ngaydangki)
VALUES ('PN1027','HCM100','2020-04-15') ;


CREATE INDEX idx_Machinhanh
ON Dangkithe (Machinhanh);




