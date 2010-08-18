




/*
'===============================================================================
'  LinqHelper.DAO.TaiKhoanNguoiDungBase
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
	public class LqTaiKhoanNguoiDungBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqTaiKhoanNguoiDungBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqTaiKhoanNguoiDungEntity obj)
		{
			provider.GetTable<LqTaiKhoanNguoiDungEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqTaiKhoanNguoiDungEntity _obj)
		{
			var q = from obj in provider.GetTable<LqTaiKhoanNguoiDungEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqTaiKhoanNguoiDungEntity tmp = q.First<LqTaiKhoanNguoiDungEntity>();
			
			tmp.TenDangNhap = _obj.TenDangNhap;
			tmp.MatKhau = _obj.MatKhau;
			tmp.NgayDangKy = _obj.NgayDangKy;
			tmp.NgayHetHan = _obj.NgayHetHan;
			tmp.HoTen = _obj.HoTen;
			tmp.MaRutGon = _obj.MaRutGon;
			tmp.BiDanh = _obj.BiDanh;
			tmp.NgaySinh = _obj.NgaySinh;
			tmp.DiaChiNoiO = _obj.DiaChiNoiO;
			tmp.IdGioiTinh = _obj.IdGioiTinh;
			tmp.QueQuan = _obj.QueQuan;
			tmp.IdDonVi = _obj.IdDonVi;
			tmp.IdChucVu = _obj.IdChucVu;
			tmp.IdDanToc = _obj.IdDanToc;
			tmp.IdTonGiao = _obj.IdTonGiao;
			tmp.IdQuocTich = _obj.IdQuocTich;
			tmp.IdTrinhDoHocVan = _obj.IdTrinhDoHocVan;
			tmp.Cmnd = _obj.Cmnd;
			tmp.ThongTinKhac = _obj.ThongTinKhac;
			tmp.ThuDienTu = _obj.ThuDienTu;
			tmp.LoaiTaiKhoan = _obj.LoaiTaiKhoan;
			tmp.IdNguoiTao = _obj.IdNguoiTao;
			tmp.NgayTao = _obj.NgayTao;
			tmp.IdNguoiCapNhat = _obj.IdNguoiCapNhat;
			tmp.NgayCapNhat = _obj.NgayCapNhat;
			tmp.TrangThai = _obj.TrangThai;
		}
		
		public void Delete(LqTaiKhoanNguoiDungEntity obj)
		{
			provider.GetTable<LqTaiKhoanNguoiDungEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqTaiKhoanNguoiDungEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqTaiKhoanNguoiDungEntity ob = (LqTaiKhoanNguoiDungEntity)q.First<LqTaiKhoanNguoiDungEntity>();
            provider.GetTable<LqTaiKhoanNguoiDungEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTenDangNhap(string TenDangNhap)
		{
			var q = from obj in provider.GetTable<LqTaiKhoanNguoiDungEntity>()
                    where obj.TenDangNhap == TenDangNhap
                    select obj;
					
            LqTaiKhoanNguoiDungEntity ob = (LqTaiKhoanNguoiDungEntity)q.First<LqTaiKhoanNguoiDungEntity>();
            provider.GetTable<LqTaiKhoanNguoiDungEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMatKhau(string MatKhau)
		{
			var q = from obj in provider.GetTable<LqTaiKhoanNguoiDungEntity>()
                    where obj.MatKhau == MatKhau
                    select obj;
					
            LqTaiKhoanNguoiDungEntity ob = (LqTaiKhoanNguoiDungEntity)q.First<LqTaiKhoanNguoiDungEntity>();
            provider.GetTable<LqTaiKhoanNguoiDungEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayDangKy(DateTime NgayDangKy)
		{
			var q = from obj in provider.GetTable<LqTaiKhoanNguoiDungEntity>()
                    where obj.NgayDangKy.Value == NgayDangKy
                    select obj;
					
            LqTaiKhoanNguoiDungEntity ob = (LqTaiKhoanNguoiDungEntity)q.First<LqTaiKhoanNguoiDungEntity>();
            provider.GetTable<LqTaiKhoanNguoiDungEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			var q = from obj in provider.GetTable<LqTaiKhoanNguoiDungEntity>()
                    where obj.NgayHetHan.Value == NgayHetHan
                    select obj;
					
            LqTaiKhoanNguoiDungEntity ob = (LqTaiKhoanNguoiDungEntity)q.First<LqTaiKhoanNguoiDungEntity>();
            provider.GetTable<LqTaiKhoanNguoiDungEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByHoTen(string HoTen)
		{
			var q = from obj in provider.GetTable<LqTaiKhoanNguoiDungEntity>()
                    where obj.HoTen == HoTen
                    select obj;
					
            LqTaiKhoanNguoiDungEntity ob = (LqTaiKhoanNguoiDungEntity)q.First<LqTaiKhoanNguoiDungEntity>();
            provider.GetTable<LqTaiKhoanNguoiDungEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqTaiKhoanNguoiDungEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqTaiKhoanNguoiDungEntity ob = (LqTaiKhoanNguoiDungEntity)q.First<LqTaiKhoanNguoiDungEntity>();
            provider.GetTable<LqTaiKhoanNguoiDungEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByBiDanh(string BiDanh)
		{
			var q = from obj in provider.GetTable<LqTaiKhoanNguoiDungEntity>()
                    where obj.BiDanh == BiDanh
                    select obj;
					
            LqTaiKhoanNguoiDungEntity ob = (LqTaiKhoanNguoiDungEntity)q.First<LqTaiKhoanNguoiDungEntity>();
            provider.GetTable<LqTaiKhoanNguoiDungEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgaySinh(DateTime NgaySinh)
		{
			var q = from obj in provider.GetTable<LqTaiKhoanNguoiDungEntity>()
                    where obj.NgaySinh.Value == NgaySinh
                    select obj;
					
            LqTaiKhoanNguoiDungEntity ob = (LqTaiKhoanNguoiDungEntity)q.First<LqTaiKhoanNguoiDungEntity>();
            provider.GetTable<LqTaiKhoanNguoiDungEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByDiaChiNoiO(string DiaChiNoiO)
		{
			var q = from obj in provider.GetTable<LqTaiKhoanNguoiDungEntity>()
                    where obj.DiaChiNoiO == DiaChiNoiO
                    select obj;
					
            LqTaiKhoanNguoiDungEntity ob = (LqTaiKhoanNguoiDungEntity)q.First<LqTaiKhoanNguoiDungEntity>();
            provider.GetTable<LqTaiKhoanNguoiDungEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdGioiTinh(Guid IdGioiTinh)
		{
			var q = from obj in provider.GetTable<LqTaiKhoanNguoiDungEntity>()
                    where obj.IdGioiTinh.Value == IdGioiTinh
                    select obj;
					
            LqTaiKhoanNguoiDungEntity ob = (LqTaiKhoanNguoiDungEntity)q.First<LqTaiKhoanNguoiDungEntity>();
            provider.GetTable<LqTaiKhoanNguoiDungEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByQueQuan(string QueQuan)
		{
			var q = from obj in provider.GetTable<LqTaiKhoanNguoiDungEntity>()
                    where obj.QueQuan == QueQuan
                    select obj;
					
            LqTaiKhoanNguoiDungEntity ob = (LqTaiKhoanNguoiDungEntity)q.First<LqTaiKhoanNguoiDungEntity>();
            provider.GetTable<LqTaiKhoanNguoiDungEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdDonVi(Guid IdDonVi)
		{
			var q = from obj in provider.GetTable<LqTaiKhoanNguoiDungEntity>()
                    where obj.IdDonVi.Value == IdDonVi
                    select obj;
					
            LqTaiKhoanNguoiDungEntity ob = (LqTaiKhoanNguoiDungEntity)q.First<LqTaiKhoanNguoiDungEntity>();
            provider.GetTable<LqTaiKhoanNguoiDungEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdChucVu(Guid IdChucVu)
		{
			var q = from obj in provider.GetTable<LqTaiKhoanNguoiDungEntity>()
                    where obj.IdChucVu.Value == IdChucVu
                    select obj;
					
            LqTaiKhoanNguoiDungEntity ob = (LqTaiKhoanNguoiDungEntity)q.First<LqTaiKhoanNguoiDungEntity>();
            provider.GetTable<LqTaiKhoanNguoiDungEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdDanToc(Guid IdDanToc)
		{
			var q = from obj in provider.GetTable<LqTaiKhoanNguoiDungEntity>()
                    where obj.IdDanToc.Value == IdDanToc
                    select obj;
					
            LqTaiKhoanNguoiDungEntity ob = (LqTaiKhoanNguoiDungEntity)q.First<LqTaiKhoanNguoiDungEntity>();
            provider.GetTable<LqTaiKhoanNguoiDungEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdTonGiao(Guid IdTonGiao)
		{
			var q = from obj in provider.GetTable<LqTaiKhoanNguoiDungEntity>()
                    where obj.IdTonGiao.Value == IdTonGiao
                    select obj;
					
            LqTaiKhoanNguoiDungEntity ob = (LqTaiKhoanNguoiDungEntity)q.First<LqTaiKhoanNguoiDungEntity>();
            provider.GetTable<LqTaiKhoanNguoiDungEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdQuocTich(Guid IdQuocTich)
		{
			var q = from obj in provider.GetTable<LqTaiKhoanNguoiDungEntity>()
                    where obj.IdQuocTich.Value == IdQuocTich
                    select obj;
					
            LqTaiKhoanNguoiDungEntity ob = (LqTaiKhoanNguoiDungEntity)q.First<LqTaiKhoanNguoiDungEntity>();
            provider.GetTable<LqTaiKhoanNguoiDungEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdTrinhDoHocVan(Guid IdTrinhDoHocVan)
		{
			var q = from obj in provider.GetTable<LqTaiKhoanNguoiDungEntity>()
                    where obj.IdTrinhDoHocVan.Value == IdTrinhDoHocVan
                    select obj;
					
            LqTaiKhoanNguoiDungEntity ob = (LqTaiKhoanNguoiDungEntity)q.First<LqTaiKhoanNguoiDungEntity>();
            provider.GetTable<LqTaiKhoanNguoiDungEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByCmnd(string Cmnd)
		{
			var q = from obj in provider.GetTable<LqTaiKhoanNguoiDungEntity>()
                    where obj.Cmnd == Cmnd
                    select obj;
					
            LqTaiKhoanNguoiDungEntity ob = (LqTaiKhoanNguoiDungEntity)q.First<LqTaiKhoanNguoiDungEntity>();
            provider.GetTable<LqTaiKhoanNguoiDungEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByThongTinKhac(string ThongTinKhac)
		{
			var q = from obj in provider.GetTable<LqTaiKhoanNguoiDungEntity>()
                    where obj.ThongTinKhac == ThongTinKhac
                    select obj;
					
            LqTaiKhoanNguoiDungEntity ob = (LqTaiKhoanNguoiDungEntity)q.First<LqTaiKhoanNguoiDungEntity>();
            provider.GetTable<LqTaiKhoanNguoiDungEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByThuDienTu(string ThuDienTu)
		{
			var q = from obj in provider.GetTable<LqTaiKhoanNguoiDungEntity>()
                    where obj.ThuDienTu == ThuDienTu
                    select obj;
					
            LqTaiKhoanNguoiDungEntity ob = (LqTaiKhoanNguoiDungEntity)q.First<LqTaiKhoanNguoiDungEntity>();
            provider.GetTable<LqTaiKhoanNguoiDungEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByLoaiTaiKhoan(string LoaiTaiKhoan)
		{
			var q = from obj in provider.GetTable<LqTaiKhoanNguoiDungEntity>()
                    where obj.LoaiTaiKhoan == LoaiTaiKhoan
                    select obj;
					
            LqTaiKhoanNguoiDungEntity ob = (LqTaiKhoanNguoiDungEntity)q.First<LqTaiKhoanNguoiDungEntity>();
            provider.GetTable<LqTaiKhoanNguoiDungEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqTaiKhoanNguoiDungEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqTaiKhoanNguoiDungEntity ob = (LqTaiKhoanNguoiDungEntity)q.First<LqTaiKhoanNguoiDungEntity>();
            provider.GetTable<LqTaiKhoanNguoiDungEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqTaiKhoanNguoiDungEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqTaiKhoanNguoiDungEntity ob = (LqTaiKhoanNguoiDungEntity)q.First<LqTaiKhoanNguoiDungEntity>();
            provider.GetTable<LqTaiKhoanNguoiDungEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqTaiKhoanNguoiDungEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqTaiKhoanNguoiDungEntity ob = (LqTaiKhoanNguoiDungEntity)q.First<LqTaiKhoanNguoiDungEntity>();
            provider.GetTable<LqTaiKhoanNguoiDungEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqTaiKhoanNguoiDungEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqTaiKhoanNguoiDungEntity ob = (LqTaiKhoanNguoiDungEntity)q.First<LqTaiKhoanNguoiDungEntity>();
            provider.GetTable<LqTaiKhoanNguoiDungEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqTaiKhoanNguoiDungEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqTaiKhoanNguoiDungEntity ob = (LqTaiKhoanNguoiDungEntity)q.First<LqTaiKhoanNguoiDungEntity>();
            provider.GetTable<LqTaiKhoanNguoiDungEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqTaiKhoanNguoiDungEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqTaiKhoanNguoiDungEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqTaiKhoanNguoiDungEntity>();
		}

		public List<LqTaiKhoanNguoiDungEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqTaiKhoanNguoiDungEntity>()
                        select obj;
            return query.ToList<LqTaiKhoanNguoiDungEntity>();
		}
		
		
		public List<LqTaiKhoanNguoiDungEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqTaiKhoanNguoiDungEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqTaiKhoanNguoiDungEntity>();
		}
		
		
		public List<LqTaiKhoanNguoiDungEntity> SelectByTenDangNhap(string TenDangNhap)
		{
			var query = from obj in provider.GetTable<LqTaiKhoanNguoiDungEntity>()
                        where obj.TenDangNhap == TenDangNhap
                        select obj;
            return query.ToList<LqTaiKhoanNguoiDungEntity>();
		}
		
		
		public List<LqTaiKhoanNguoiDungEntity> SelectByMatKhau(string MatKhau)
		{
			var query = from obj in provider.GetTable<LqTaiKhoanNguoiDungEntity>()
                        where obj.MatKhau == MatKhau
                        select obj;
            return query.ToList<LqTaiKhoanNguoiDungEntity>();
		}
		
		
		public List<LqTaiKhoanNguoiDungEntity> SelectByNgayDangKy(DateTime NgayDangKy)
		{
			var query = from obj in provider.GetTable<LqTaiKhoanNguoiDungEntity>()
                        where obj.NgayDangKy.Value == NgayDangKy
                        select obj;
            return query.ToList<LqTaiKhoanNguoiDungEntity>();
		}
		
		
		public List<LqTaiKhoanNguoiDungEntity> SelectByNgayHetHan(DateTime NgayHetHan)
		{
			var query = from obj in provider.GetTable<LqTaiKhoanNguoiDungEntity>()
                        where obj.NgayHetHan.Value == NgayHetHan
                        select obj;
            return query.ToList<LqTaiKhoanNguoiDungEntity>();
		}
		
		
		public List<LqTaiKhoanNguoiDungEntity> SelectByHoTen(string HoTen)
		{
			var query = from obj in provider.GetTable<LqTaiKhoanNguoiDungEntity>()
                        where obj.HoTen == HoTen
                        select obj;
            return query.ToList<LqTaiKhoanNguoiDungEntity>();
		}
		
		
		public List<LqTaiKhoanNguoiDungEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqTaiKhoanNguoiDungEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqTaiKhoanNguoiDungEntity>();
		}
		
		
		public List<LqTaiKhoanNguoiDungEntity> SelectByBiDanh(string BiDanh)
		{
			var query = from obj in provider.GetTable<LqTaiKhoanNguoiDungEntity>()
                        where obj.BiDanh == BiDanh
                        select obj;
            return query.ToList<LqTaiKhoanNguoiDungEntity>();
		}
		
		
		public List<LqTaiKhoanNguoiDungEntity> SelectByNgaySinh(DateTime NgaySinh)
		{
			var query = from obj in provider.GetTable<LqTaiKhoanNguoiDungEntity>()
                        where obj.NgaySinh.Value == NgaySinh
                        select obj;
            return query.ToList<LqTaiKhoanNguoiDungEntity>();
		}
		
		
		public List<LqTaiKhoanNguoiDungEntity> SelectByDiaChiNoiO(string DiaChiNoiO)
		{
			var query = from obj in provider.GetTable<LqTaiKhoanNguoiDungEntity>()
                        where obj.DiaChiNoiO == DiaChiNoiO
                        select obj;
            return query.ToList<LqTaiKhoanNguoiDungEntity>();
		}
		
		
		public List<LqTaiKhoanNguoiDungEntity> SelectByIdGioiTinh(Guid IdGioiTinh)
		{
			var query = from obj in provider.GetTable<LqTaiKhoanNguoiDungEntity>()
                        where obj.IdGioiTinh.Value == IdGioiTinh
                        select obj;
            return query.ToList<LqTaiKhoanNguoiDungEntity>();
		}
		
		
		public List<LqTaiKhoanNguoiDungEntity> SelectByQueQuan(string QueQuan)
		{
			var query = from obj in provider.GetTable<LqTaiKhoanNguoiDungEntity>()
                        where obj.QueQuan == QueQuan
                        select obj;
            return query.ToList<LqTaiKhoanNguoiDungEntity>();
		}
		
		
		public List<LqTaiKhoanNguoiDungEntity> SelectByIdDonVi(Guid IdDonVi)
		{
			var query = from obj in provider.GetTable<LqTaiKhoanNguoiDungEntity>()
                        where obj.IdDonVi.Value == IdDonVi
                        select obj;
            return query.ToList<LqTaiKhoanNguoiDungEntity>();
		}
		
		
		public List<LqTaiKhoanNguoiDungEntity> SelectByIdChucVu(Guid IdChucVu)
		{
			var query = from obj in provider.GetTable<LqTaiKhoanNguoiDungEntity>()
                        where obj.IdChucVu.Value == IdChucVu
                        select obj;
            return query.ToList<LqTaiKhoanNguoiDungEntity>();
		}
		
		
		public List<LqTaiKhoanNguoiDungEntity> SelectByIdDanToc(Guid IdDanToc)
		{
			var query = from obj in provider.GetTable<LqTaiKhoanNguoiDungEntity>()
                        where obj.IdDanToc.Value == IdDanToc
                        select obj;
            return query.ToList<LqTaiKhoanNguoiDungEntity>();
		}
		
		
		public List<LqTaiKhoanNguoiDungEntity> SelectByIdTonGiao(Guid IdTonGiao)
		{
			var query = from obj in provider.GetTable<LqTaiKhoanNguoiDungEntity>()
                        where obj.IdTonGiao.Value == IdTonGiao
                        select obj;
            return query.ToList<LqTaiKhoanNguoiDungEntity>();
		}
		
		
		public List<LqTaiKhoanNguoiDungEntity> SelectByIdQuocTich(Guid IdQuocTich)
		{
			var query = from obj in provider.GetTable<LqTaiKhoanNguoiDungEntity>()
                        where obj.IdQuocTich.Value == IdQuocTich
                        select obj;
            return query.ToList<LqTaiKhoanNguoiDungEntity>();
		}
		
		
		public List<LqTaiKhoanNguoiDungEntity> SelectByIdTrinhDoHocVan(Guid IdTrinhDoHocVan)
		{
			var query = from obj in provider.GetTable<LqTaiKhoanNguoiDungEntity>()
                        where obj.IdTrinhDoHocVan.Value == IdTrinhDoHocVan
                        select obj;
            return query.ToList<LqTaiKhoanNguoiDungEntity>();
		}
		
		
		public List<LqTaiKhoanNguoiDungEntity> SelectByCmnd(string Cmnd)
		{
			var query = from obj in provider.GetTable<LqTaiKhoanNguoiDungEntity>()
                        where obj.Cmnd == Cmnd
                        select obj;
            return query.ToList<LqTaiKhoanNguoiDungEntity>();
		}
		
		
		public List<LqTaiKhoanNguoiDungEntity> SelectByThongTinKhac(string ThongTinKhac)
		{
			var query = from obj in provider.GetTable<LqTaiKhoanNguoiDungEntity>()
                        where obj.ThongTinKhac == ThongTinKhac
                        select obj;
            return query.ToList<LqTaiKhoanNguoiDungEntity>();
		}
		
		
		public List<LqTaiKhoanNguoiDungEntity> SelectByThuDienTu(string ThuDienTu)
		{
			var query = from obj in provider.GetTable<LqTaiKhoanNguoiDungEntity>()
                        where obj.ThuDienTu == ThuDienTu
                        select obj;
            return query.ToList<LqTaiKhoanNguoiDungEntity>();
		}
		
		
		public List<LqTaiKhoanNguoiDungEntity> SelectByLoaiTaiKhoan(string LoaiTaiKhoan)
		{
			var query = from obj in provider.GetTable<LqTaiKhoanNguoiDungEntity>()
                        where obj.LoaiTaiKhoan == LoaiTaiKhoan
                        select obj;
            return query.ToList<LqTaiKhoanNguoiDungEntity>();
		}
		
		
		public List<LqTaiKhoanNguoiDungEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqTaiKhoanNguoiDungEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqTaiKhoanNguoiDungEntity>();
		}
		
		
		public List<LqTaiKhoanNguoiDungEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqTaiKhoanNguoiDungEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqTaiKhoanNguoiDungEntity>();
		}
		
		
		public List<LqTaiKhoanNguoiDungEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqTaiKhoanNguoiDungEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqTaiKhoanNguoiDungEntity>();
		}
		
		
		public List<LqTaiKhoanNguoiDungEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqTaiKhoanNguoiDungEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqTaiKhoanNguoiDungEntity>();
		}
		
		
		public List<LqTaiKhoanNguoiDungEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqTaiKhoanNguoiDungEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqTaiKhoanNguoiDungEntity>();
		}
		
		
		

	}
}
