




/*
'===============================================================================
'  LinqHelper.DAO.NanNhanBase
'===============================================================================
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using LinqHelper;
using LinqHelper.Entity;
using LinqHelper.DAO;

namespace LinqHelper.DAO
{
	public class LqNanNhanBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqNanNhanBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqNanNhanEntity obj)
		{
			provider.GetTable<LqNanNhanEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqNanNhanEntity _obj)
		{
			var q = from obj in provider.GetTable<LqNanNhanEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqNanNhanEntity tmp = q.First<LqNanNhanEntity>();
			
			tmp.HoTen = _obj.HoTen;
			tmp.HoTenThuongDung = _obj.HoTenThuongDung;
			tmp.BiDanh = _obj.BiDanh;
			tmp.MaRutGon = _obj.MaRutGon;
			tmp.IdGioiTinh = _obj.IdGioiTinh;
			tmp.SinhNgay = _obj.SinhNgay;
			tmp.QueQuan = _obj.QueQuan;
			tmp.DiaChiNoiO = _obj.DiaChiNoiO;
			tmp.IdQuocTich = _obj.IdQuocTich;
			tmp.Cmnd = _obj.Cmnd;
			tmp.IdDanToc = _obj.IdDanToc;
			tmp.IdTrinhDoHocVan = _obj.IdTrinhDoHocVan;
			tmp.IdNgheNghiep = _obj.IdNgheNghiep;
			tmp.IdTinhTrangChinhTri = _obj.IdTinhTrangChinhTri;
			tmp.IdTinhTrangTheTrang = _obj.IdTinhTrangTheTrang;
			tmp.ThongTinKhac = _obj.ThongTinKhac;
			tmp.IdNguoiTao = _obj.IdNguoiTao;
			tmp.NgayTao = _obj.NgayTao;
			tmp.IdNguoiCapNhat = _obj.IdNguoiCapNhat;
			tmp.NgayCapNhat = _obj.NgayCapNhat;
			tmp.TrangThai = _obj.TrangThai;
		}
		
		public void Delete(LqNanNhanEntity obj)
		{
			provider.GetTable<LqNanNhanEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqNanNhanEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqNanNhanEntity ob = (LqNanNhanEntity)q.First<LqNanNhanEntity>();
            provider.GetTable<LqNanNhanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByHoTen(string HoTen)
		{
			var q = from obj in provider.GetTable<LqNanNhanEntity>()
                    where obj.HoTen == HoTen
                    select obj;
					
            LqNanNhanEntity ob = (LqNanNhanEntity)q.First<LqNanNhanEntity>();
            provider.GetTable<LqNanNhanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByHoTenThuongDung(string HoTenThuongDung)
		{
			var q = from obj in provider.GetTable<LqNanNhanEntity>()
                    where obj.HoTenThuongDung == HoTenThuongDung
                    select obj;
					
            LqNanNhanEntity ob = (LqNanNhanEntity)q.First<LqNanNhanEntity>();
            provider.GetTable<LqNanNhanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByBiDanh(string BiDanh)
		{
			var q = from obj in provider.GetTable<LqNanNhanEntity>()
                    where obj.BiDanh == BiDanh
                    select obj;
					
            LqNanNhanEntity ob = (LqNanNhanEntity)q.First<LqNanNhanEntity>();
            provider.GetTable<LqNanNhanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqNanNhanEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqNanNhanEntity ob = (LqNanNhanEntity)q.First<LqNanNhanEntity>();
            provider.GetTable<LqNanNhanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdGioiTinh(Guid IdGioiTinh)
		{
			var q = from obj in provider.GetTable<LqNanNhanEntity>()
                    where obj.IdGioiTinh.Value == IdGioiTinh
                    select obj;
					
            LqNanNhanEntity ob = (LqNanNhanEntity)q.First<LqNanNhanEntity>();
            provider.GetTable<LqNanNhanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteBySinhNgay(DateTime SinhNgay)
		{
			var q = from obj in provider.GetTable<LqNanNhanEntity>()
                    where obj.SinhNgay.Value == SinhNgay
                    select obj;
					
            LqNanNhanEntity ob = (LqNanNhanEntity)q.First<LqNanNhanEntity>();
            provider.GetTable<LqNanNhanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByQueQuan(string QueQuan)
		{
			var q = from obj in provider.GetTable<LqNanNhanEntity>()
                    where obj.QueQuan == QueQuan
                    select obj;
					
            LqNanNhanEntity ob = (LqNanNhanEntity)q.First<LqNanNhanEntity>();
            provider.GetTable<LqNanNhanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByDiaChiNoiO(string DiaChiNoiO)
		{
			var q = from obj in provider.GetTable<LqNanNhanEntity>()
                    where obj.DiaChiNoiO == DiaChiNoiO
                    select obj;
					
            LqNanNhanEntity ob = (LqNanNhanEntity)q.First<LqNanNhanEntity>();
            provider.GetTable<LqNanNhanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdQuocTich(Guid IdQuocTich)
		{
			var q = from obj in provider.GetTable<LqNanNhanEntity>()
                    where obj.IdQuocTich.Value == IdQuocTich
                    select obj;
					
            LqNanNhanEntity ob = (LqNanNhanEntity)q.First<LqNanNhanEntity>();
            provider.GetTable<LqNanNhanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByCmnd(string Cmnd)
		{
			var q = from obj in provider.GetTable<LqNanNhanEntity>()
                    where obj.Cmnd == Cmnd
                    select obj;
					
            LqNanNhanEntity ob = (LqNanNhanEntity)q.First<LqNanNhanEntity>();
            provider.GetTable<LqNanNhanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdDanToc(Guid IdDanToc)
		{
			var q = from obj in provider.GetTable<LqNanNhanEntity>()
                    where obj.IdDanToc.Value == IdDanToc
                    select obj;
					
            LqNanNhanEntity ob = (LqNanNhanEntity)q.First<LqNanNhanEntity>();
            provider.GetTable<LqNanNhanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdTrinhDoHocVan(Guid IdTrinhDoHocVan)
		{
			var q = from obj in provider.GetTable<LqNanNhanEntity>()
                    where obj.IdTrinhDoHocVan.Value == IdTrinhDoHocVan
                    select obj;
					
            LqNanNhanEntity ob = (LqNanNhanEntity)q.First<LqNanNhanEntity>();
            provider.GetTable<LqNanNhanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNgheNghiep(Guid IdNgheNghiep)
		{
			var q = from obj in provider.GetTable<LqNanNhanEntity>()
                    where obj.IdNgheNghiep.Value == IdNgheNghiep
                    select obj;
					
            LqNanNhanEntity ob = (LqNanNhanEntity)q.First<LqNanNhanEntity>();
            provider.GetTable<LqNanNhanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdTinhTrangChinhTri(Guid IdTinhTrangChinhTri)
		{
			var q = from obj in provider.GetTable<LqNanNhanEntity>()
                    where obj.IdTinhTrangChinhTri.Value == IdTinhTrangChinhTri
                    select obj;
					
            LqNanNhanEntity ob = (LqNanNhanEntity)q.First<LqNanNhanEntity>();
            provider.GetTable<LqNanNhanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdTinhTrangTheTrang(Guid IdTinhTrangTheTrang)
		{
			var q = from obj in provider.GetTable<LqNanNhanEntity>()
                    where obj.IdTinhTrangTheTrang.Value == IdTinhTrangTheTrang
                    select obj;
					
            LqNanNhanEntity ob = (LqNanNhanEntity)q.First<LqNanNhanEntity>();
            provider.GetTable<LqNanNhanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByThongTinKhac(string ThongTinKhac)
		{
			var q = from obj in provider.GetTable<LqNanNhanEntity>()
                    where obj.ThongTinKhac == ThongTinKhac
                    select obj;
					
            LqNanNhanEntity ob = (LqNanNhanEntity)q.First<LqNanNhanEntity>();
            provider.GetTable<LqNanNhanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqNanNhanEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqNanNhanEntity ob = (LqNanNhanEntity)q.First<LqNanNhanEntity>();
            provider.GetTable<LqNanNhanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqNanNhanEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqNanNhanEntity ob = (LqNanNhanEntity)q.First<LqNanNhanEntity>();
            provider.GetTable<LqNanNhanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqNanNhanEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqNanNhanEntity ob = (LqNanNhanEntity)q.First<LqNanNhanEntity>();
            provider.GetTable<LqNanNhanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqNanNhanEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqNanNhanEntity ob = (LqNanNhanEntity)q.First<LqNanNhanEntity>();
            provider.GetTable<LqNanNhanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqNanNhanEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqNanNhanEntity ob = (LqNanNhanEntity)q.First<LqNanNhanEntity>();
            provider.GetTable<LqNanNhanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqNanNhanEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqNanNhanEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqNanNhanEntity>();
		}

		public List<LqNanNhanEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqNanNhanEntity>()
                        select obj;
            return query.ToList<LqNanNhanEntity>();
		}
		
		
		public List<LqNanNhanEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqNanNhanEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqNanNhanEntity>();
		}
		
		
		public List<LqNanNhanEntity> SelectByHoTen(string HoTen)
		{
			var query = from obj in provider.GetTable<LqNanNhanEntity>()
                        where obj.HoTen == HoTen
                        select obj;
            return query.ToList<LqNanNhanEntity>();
		}
		
		
		public List<LqNanNhanEntity> SelectByHoTenThuongDung(string HoTenThuongDung)
		{
			var query = from obj in provider.GetTable<LqNanNhanEntity>()
                        where obj.HoTenThuongDung == HoTenThuongDung
                        select obj;
            return query.ToList<LqNanNhanEntity>();
		}
		
		
		public List<LqNanNhanEntity> SelectByBiDanh(string BiDanh)
		{
			var query = from obj in provider.GetTable<LqNanNhanEntity>()
                        where obj.BiDanh == BiDanh
                        select obj;
            return query.ToList<LqNanNhanEntity>();
		}
		
		
		public List<LqNanNhanEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqNanNhanEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqNanNhanEntity>();
		}
		
		
		public List<LqNanNhanEntity> SelectByIdGioiTinh(Guid IdGioiTinh)
		{
			var query = from obj in provider.GetTable<LqNanNhanEntity>()
                        where obj.IdGioiTinh.Value == IdGioiTinh
                        select obj;
            return query.ToList<LqNanNhanEntity>();
		}
		
		
		public List<LqNanNhanEntity> SelectBySinhNgay(DateTime SinhNgay)
		{
			var query = from obj in provider.GetTable<LqNanNhanEntity>()
                        where obj.SinhNgay.Value == SinhNgay
                        select obj;
            return query.ToList<LqNanNhanEntity>();
		}
		
		
		public List<LqNanNhanEntity> SelectByQueQuan(string QueQuan)
		{
			var query = from obj in provider.GetTable<LqNanNhanEntity>()
                        where obj.QueQuan == QueQuan
                        select obj;
            return query.ToList<LqNanNhanEntity>();
		}
		
		
		public List<LqNanNhanEntity> SelectByDiaChiNoiO(string DiaChiNoiO)
		{
			var query = from obj in provider.GetTable<LqNanNhanEntity>()
                        where obj.DiaChiNoiO == DiaChiNoiO
                        select obj;
            return query.ToList<LqNanNhanEntity>();
		}
		
		
		public List<LqNanNhanEntity> SelectByIdQuocTich(Guid IdQuocTich)
		{
			var query = from obj in provider.GetTable<LqNanNhanEntity>()
                        where obj.IdQuocTich.Value == IdQuocTich
                        select obj;
            return query.ToList<LqNanNhanEntity>();
		}
		
		
		public List<LqNanNhanEntity> SelectByCmnd(string Cmnd)
		{
			var query = from obj in provider.GetTable<LqNanNhanEntity>()
                        where obj.Cmnd == Cmnd
                        select obj;
            return query.ToList<LqNanNhanEntity>();
		}
		
		
		public List<LqNanNhanEntity> SelectByIdDanToc(Guid IdDanToc)
		{
			var query = from obj in provider.GetTable<LqNanNhanEntity>()
                        where obj.IdDanToc.Value == IdDanToc
                        select obj;
            return query.ToList<LqNanNhanEntity>();
		}
		
		
		public List<LqNanNhanEntity> SelectByIdTrinhDoHocVan(Guid IdTrinhDoHocVan)
		{
			var query = from obj in provider.GetTable<LqNanNhanEntity>()
                        where obj.IdTrinhDoHocVan.Value == IdTrinhDoHocVan
                        select obj;
            return query.ToList<LqNanNhanEntity>();
		}
		
		
		public List<LqNanNhanEntity> SelectByIdNgheNghiep(Guid IdNgheNghiep)
		{
			var query = from obj in provider.GetTable<LqNanNhanEntity>()
                        where obj.IdNgheNghiep.Value == IdNgheNghiep
                        select obj;
            return query.ToList<LqNanNhanEntity>();
		}
		
		
		public List<LqNanNhanEntity> SelectByIdTinhTrangChinhTri(Guid IdTinhTrangChinhTri)
		{
			var query = from obj in provider.GetTable<LqNanNhanEntity>()
                        where obj.IdTinhTrangChinhTri.Value == IdTinhTrangChinhTri
                        select obj;
            return query.ToList<LqNanNhanEntity>();
		}
		
		
		public List<LqNanNhanEntity> SelectByIdTinhTrangTheTrang(Guid IdTinhTrangTheTrang)
		{
			var query = from obj in provider.GetTable<LqNanNhanEntity>()
                        where obj.IdTinhTrangTheTrang.Value == IdTinhTrangTheTrang
                        select obj;
            return query.ToList<LqNanNhanEntity>();
		}
		
		
		public List<LqNanNhanEntity> SelectByThongTinKhac(string ThongTinKhac)
		{
			var query = from obj in provider.GetTable<LqNanNhanEntity>()
                        where obj.ThongTinKhac == ThongTinKhac
                        select obj;
            return query.ToList<LqNanNhanEntity>();
		}
		
		
		public List<LqNanNhanEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqNanNhanEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqNanNhanEntity>();
		}
		
		
		public List<LqNanNhanEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqNanNhanEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqNanNhanEntity>();
		}
		
		
		public List<LqNanNhanEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqNanNhanEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqNanNhanEntity>();
		}
		
		
		public List<LqNanNhanEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqNanNhanEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqNanNhanEntity>();
		}
		
		
		public List<LqNanNhanEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqNanNhanEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqNanNhanEntity>();
		}
		
		
		

	}
}
