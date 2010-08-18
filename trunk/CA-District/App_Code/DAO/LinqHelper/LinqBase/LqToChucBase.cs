




/*
'===============================================================================
'  LinqHelper.DAO.ToChucBase
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
	public class LqToChucBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqToChucBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqToChucEntity obj)
		{
			provider.GetTable<LqToChucEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqToChucEntity _obj)
		{
			var q = from obj in provider.GetTable<LqToChucEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqToChucEntity tmp = q.First<LqToChucEntity>();
			
			tmp.TenToChuc = _obj.TenToChuc;
			tmp.MaRutGon = _obj.MaRutGon;
			tmp.IdNuoc = _obj.IdNuoc;
			tmp.IdTinh = _obj.IdTinh;
			tmp.IdHuyen = _obj.IdHuyen;
			tmp.IdXa = _obj.IdXa;
			tmp.Duong = _obj.Duong;
			tmp.SoNha = _obj.SoNha;
			tmp.DiaChiKhac = _obj.DiaChiKhac;
			tmp.TonChi = _obj.TonChi;
			tmp.DoiTuongDungDau = _obj.DoiTuongDungDau;
			tmp.SoDienThoai = _obj.SoDienThoai;
			tmp.TongSoDoiTuong = _obj.TongSoDoiTuong;
			tmp.ThanhVien = _obj.ThanhVien;
			tmp.MangLuoi = _obj.MangLuoi;
			tmp.BieuTuong = _obj.BieuTuong;
			tmp.IdNguoiTao = _obj.IdNguoiTao;
			tmp.NgayTao = _obj.NgayTao;
			tmp.IdNguoiCapNhat = _obj.IdNguoiCapNhat;
			tmp.NgayCapNhat = _obj.NgayCapNhat;
			tmp.TrangThai = _obj.TrangThai;
		}
		
		public void Delete(LqToChucEntity obj)
		{
			provider.GetTable<LqToChucEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqToChucEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqToChucEntity ob = (LqToChucEntity)q.First<LqToChucEntity>();
            provider.GetTable<LqToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTenToChuc(string TenToChuc)
		{
			var q = from obj in provider.GetTable<LqToChucEntity>()
                    where obj.TenToChuc == TenToChuc
                    select obj;
					
            LqToChucEntity ob = (LqToChucEntity)q.First<LqToChucEntity>();
            provider.GetTable<LqToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqToChucEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqToChucEntity ob = (LqToChucEntity)q.First<LqToChucEntity>();
            provider.GetTable<LqToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNuoc(Guid IdNuoc)
		{
			var q = from obj in provider.GetTable<LqToChucEntity>()
                    where obj.IdNuoc.Value == IdNuoc
                    select obj;
					
            LqToChucEntity ob = (LqToChucEntity)q.First<LqToChucEntity>();
            provider.GetTable<LqToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdTinh(Guid IdTinh)
		{
			var q = from obj in provider.GetTable<LqToChucEntity>()
                    where obj.IdTinh.Value == IdTinh
                    select obj;
					
            LqToChucEntity ob = (LqToChucEntity)q.First<LqToChucEntity>();
            provider.GetTable<LqToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdHuyen(Guid IdHuyen)
		{
			var q = from obj in provider.GetTable<LqToChucEntity>()
                    where obj.IdHuyen.Value == IdHuyen
                    select obj;
					
            LqToChucEntity ob = (LqToChucEntity)q.First<LqToChucEntity>();
            provider.GetTable<LqToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdXa(Guid IdXa)
		{
			var q = from obj in provider.GetTable<LqToChucEntity>()
                    where obj.IdXa.Value == IdXa
                    select obj;
					
            LqToChucEntity ob = (LqToChucEntity)q.First<LqToChucEntity>();
            provider.GetTable<LqToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByDuong(string Duong)
		{
			var q = from obj in provider.GetTable<LqToChucEntity>()
                    where obj.Duong == Duong
                    select obj;
					
            LqToChucEntity ob = (LqToChucEntity)q.First<LqToChucEntity>();
            provider.GetTable<LqToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteBySoNha(string SoNha)
		{
			var q = from obj in provider.GetTable<LqToChucEntity>()
                    where obj.SoNha == SoNha
                    select obj;
					
            LqToChucEntity ob = (LqToChucEntity)q.First<LqToChucEntity>();
            provider.GetTable<LqToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByDiaChiKhac(string DiaChiKhac)
		{
			var q = from obj in provider.GetTable<LqToChucEntity>()
                    where obj.DiaChiKhac == DiaChiKhac
                    select obj;
					
            LqToChucEntity ob = (LqToChucEntity)q.First<LqToChucEntity>();
            provider.GetTable<LqToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTonChi(string TonChi)
		{
			var q = from obj in provider.GetTable<LqToChucEntity>()
                    where obj.TonChi == TonChi
                    select obj;
					
            LqToChucEntity ob = (LqToChucEntity)q.First<LqToChucEntity>();
            provider.GetTable<LqToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByDoiTuongDungDau(string DoiTuongDungDau)
		{
			var q = from obj in provider.GetTable<LqToChucEntity>()
                    where obj.DoiTuongDungDau == DoiTuongDungDau
                    select obj;
					
            LqToChucEntity ob = (LqToChucEntity)q.First<LqToChucEntity>();
            provider.GetTable<LqToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteBySoDienThoai(string SoDienThoai)
		{
			var q = from obj in provider.GetTable<LqToChucEntity>()
                    where obj.SoDienThoai == SoDienThoai
                    select obj;
					
            LqToChucEntity ob = (LqToChucEntity)q.First<LqToChucEntity>();
            provider.GetTable<LqToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTongSoDoiTuong(int TongSoDoiTuong)
		{
			var q = from obj in provider.GetTable<LqToChucEntity>()
                    where obj.TongSoDoiTuong.Value == TongSoDoiTuong
                    select obj;
					
            LqToChucEntity ob = (LqToChucEntity)q.First<LqToChucEntity>();
            provider.GetTable<LqToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByThanhVien(string ThanhVien)
		{
			var q = from obj in provider.GetTable<LqToChucEntity>()
                    where obj.ThanhVien == ThanhVien
                    select obj;
					
            LqToChucEntity ob = (LqToChucEntity)q.First<LqToChucEntity>();
            provider.GetTable<LqToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMangLuoi(string MangLuoi)
		{
			var q = from obj in provider.GetTable<LqToChucEntity>()
                    where obj.MangLuoi == MangLuoi
                    select obj;
					
            LqToChucEntity ob = (LqToChucEntity)q.First<LqToChucEntity>();
            provider.GetTable<LqToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByBieuTuong(string BieuTuong)
		{
			var q = from obj in provider.GetTable<LqToChucEntity>()
                    where obj.BieuTuong == BieuTuong
                    select obj;
					
            LqToChucEntity ob = (LqToChucEntity)q.First<LqToChucEntity>();
            provider.GetTable<LqToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqToChucEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqToChucEntity ob = (LqToChucEntity)q.First<LqToChucEntity>();
            provider.GetTable<LqToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqToChucEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqToChucEntity ob = (LqToChucEntity)q.First<LqToChucEntity>();
            provider.GetTable<LqToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqToChucEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqToChucEntity ob = (LqToChucEntity)q.First<LqToChucEntity>();
            provider.GetTable<LqToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqToChucEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqToChucEntity ob = (LqToChucEntity)q.First<LqToChucEntity>();
            provider.GetTable<LqToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqToChucEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqToChucEntity ob = (LqToChucEntity)q.First<LqToChucEntity>();
            provider.GetTable<LqToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqToChucEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqToChucEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqToChucEntity>();
		}

		public List<LqToChucEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqToChucEntity>()
                        select obj;
            return query.ToList<LqToChucEntity>();
		}
		
		
		public List<LqToChucEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqToChucEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqToChucEntity>();
		}
		
		
		public List<LqToChucEntity> SelectByTenToChuc(string TenToChuc)
		{
			var query = from obj in provider.GetTable<LqToChucEntity>()
                        where obj.TenToChuc == TenToChuc
                        select obj;
            return query.ToList<LqToChucEntity>();
		}
		
		
		public List<LqToChucEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqToChucEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqToChucEntity>();
		}
		
		
		public List<LqToChucEntity> SelectByIdNuoc(Guid IdNuoc)
		{
			var query = from obj in provider.GetTable<LqToChucEntity>()
                        where obj.IdNuoc.Value == IdNuoc
                        select obj;
            return query.ToList<LqToChucEntity>();
		}
		
		
		public List<LqToChucEntity> SelectByIdTinh(Guid IdTinh)
		{
			var query = from obj in provider.GetTable<LqToChucEntity>()
                        where obj.IdTinh.Value == IdTinh
                        select obj;
            return query.ToList<LqToChucEntity>();
		}
		
		
		public List<LqToChucEntity> SelectByIdHuyen(Guid IdHuyen)
		{
			var query = from obj in provider.GetTable<LqToChucEntity>()
                        where obj.IdHuyen.Value == IdHuyen
                        select obj;
            return query.ToList<LqToChucEntity>();
		}
		
		
		public List<LqToChucEntity> SelectByIdXa(Guid IdXa)
		{
			var query = from obj in provider.GetTable<LqToChucEntity>()
                        where obj.IdXa.Value == IdXa
                        select obj;
            return query.ToList<LqToChucEntity>();
		}
		
		
		public List<LqToChucEntity> SelectByDuong(string Duong)
		{
			var query = from obj in provider.GetTable<LqToChucEntity>()
                        where obj.Duong == Duong
                        select obj;
            return query.ToList<LqToChucEntity>();
		}
		
		
		public List<LqToChucEntity> SelectBySoNha(string SoNha)
		{
			var query = from obj in provider.GetTable<LqToChucEntity>()
                        where obj.SoNha == SoNha
                        select obj;
            return query.ToList<LqToChucEntity>();
		}
		
		
		public List<LqToChucEntity> SelectByDiaChiKhac(string DiaChiKhac)
		{
			var query = from obj in provider.GetTable<LqToChucEntity>()
                        where obj.DiaChiKhac == DiaChiKhac
                        select obj;
            return query.ToList<LqToChucEntity>();
		}
		
		
		public List<LqToChucEntity> SelectByTonChi(string TonChi)
		{
			var query = from obj in provider.GetTable<LqToChucEntity>()
                        where obj.TonChi == TonChi
                        select obj;
            return query.ToList<LqToChucEntity>();
		}
		
		
		public List<LqToChucEntity> SelectByDoiTuongDungDau(string DoiTuongDungDau)
		{
			var query = from obj in provider.GetTable<LqToChucEntity>()
                        where obj.DoiTuongDungDau == DoiTuongDungDau
                        select obj;
            return query.ToList<LqToChucEntity>();
		}
		
		
		public List<LqToChucEntity> SelectBySoDienThoai(string SoDienThoai)
		{
			var query = from obj in provider.GetTable<LqToChucEntity>()
                        where obj.SoDienThoai == SoDienThoai
                        select obj;
            return query.ToList<LqToChucEntity>();
		}
		
		
		public List<LqToChucEntity> SelectByTongSoDoiTuong(int TongSoDoiTuong)
		{
			var query = from obj in provider.GetTable<LqToChucEntity>()
                        where obj.TongSoDoiTuong.Value == TongSoDoiTuong
                        select obj;
            return query.ToList<LqToChucEntity>();
		}
		
		
		public List<LqToChucEntity> SelectByThanhVien(string ThanhVien)
		{
			var query = from obj in provider.GetTable<LqToChucEntity>()
                        where obj.ThanhVien == ThanhVien
                        select obj;
            return query.ToList<LqToChucEntity>();
		}
		
		
		public List<LqToChucEntity> SelectByMangLuoi(string MangLuoi)
		{
			var query = from obj in provider.GetTable<LqToChucEntity>()
                        where obj.MangLuoi == MangLuoi
                        select obj;
            return query.ToList<LqToChucEntity>();
		}
		
		
		public List<LqToChucEntity> SelectByBieuTuong(string BieuTuong)
		{
			var query = from obj in provider.GetTable<LqToChucEntity>()
                        where obj.BieuTuong == BieuTuong
                        select obj;
            return query.ToList<LqToChucEntity>();
		}
		
		
		public List<LqToChucEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqToChucEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqToChucEntity>();
		}
		
		
		public List<LqToChucEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqToChucEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqToChucEntity>();
		}
		
		
		public List<LqToChucEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqToChucEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqToChucEntity>();
		}
		
		
		public List<LqToChucEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqToChucEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqToChucEntity>();
		}
		
		
		public List<LqToChucEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqToChucEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqToChucEntity>();
		}
		
		
		

	}
}
