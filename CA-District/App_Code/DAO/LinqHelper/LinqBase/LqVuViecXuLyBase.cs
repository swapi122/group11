




/*
'===============================================================================
'  LinqHelper.DAO.VuViecXuLyBase
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
	public class LqVuViecXuLyBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqVuViecXuLyBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqVuViecXuLyEntity obj)
		{
			provider.GetTable<LqVuViecXuLyEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqVuViecXuLyEntity _obj)
		{
			var q = from obj in provider.GetTable<LqVuViecXuLyEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqVuViecXuLyEntity tmp = q.First<LqVuViecXuLyEntity>();
			
			tmp.IdVuViec = _obj.IdVuViec;
			tmp.IdCapChiDao = _obj.IdCapChiDao;
			tmp.NoiDung = _obj.NoiDung;
			tmp.KetQuaThucHien = _obj.KetQuaThucHien;
			tmp.IdDonViXuLy = _obj.IdDonViXuLy;
			tmp.IdHinhThucXuLy = _obj.IdHinhThucXuLy;
			tmp.SoHinhThucXuLy = _obj.SoHinhThucXuLy;
			tmp.NgayXuLy = _obj.NgayXuLy;
			tmp.NgayKetLuan = _obj.NgayKetLuan;
			tmp.SoDinhChiTamDinhChi = _obj.SoDinhChiTamDinhChi;
			tmp.NgayDinhChi = _obj.NgayDinhChi;
			tmp.SoBanAn = _obj.SoBanAn;
			tmp.NgayBanAn = _obj.NgayBanAn;
			tmp.IdNguoiTao = _obj.IdNguoiTao;
			tmp.NgayTao = _obj.NgayTao;
			tmp.IdNguoiCapNhat = _obj.IdNguoiCapNhat;
			tmp.NgayCapNhat = _obj.NgayCapNhat;
			tmp.TrangThai = _obj.TrangThai;
		}
		
		public void Delete(LqVuViecXuLyEntity obj)
		{
			provider.GetTable<LqVuViecXuLyEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqVuViecXuLyEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqVuViecXuLyEntity ob = (LqVuViecXuLyEntity)q.First<LqVuViecXuLyEntity>();
            provider.GetTable<LqVuViecXuLyEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdVuViec(Guid IdVuViec)
		{
			var q = from obj in provider.GetTable<LqVuViecXuLyEntity>()
                    where obj.IdVuViec == IdVuViec
                    select obj;
					
            LqVuViecXuLyEntity ob = (LqVuViecXuLyEntity)q.First<LqVuViecXuLyEntity>();
            provider.GetTable<LqVuViecXuLyEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdCapChiDao(Guid IdCapChiDao)
		{
			var q = from obj in provider.GetTable<LqVuViecXuLyEntity>()
                    where obj.IdCapChiDao.Value == IdCapChiDao
                    select obj;
					
            LqVuViecXuLyEntity ob = (LqVuViecXuLyEntity)q.First<LqVuViecXuLyEntity>();
            provider.GetTable<LqVuViecXuLyEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNoiDung(string NoiDung)
		{
			var q = from obj in provider.GetTable<LqVuViecXuLyEntity>()
                    where obj.NoiDung == NoiDung
                    select obj;
					
            LqVuViecXuLyEntity ob = (LqVuViecXuLyEntity)q.First<LqVuViecXuLyEntity>();
            provider.GetTable<LqVuViecXuLyEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByKetQuaThucHien(string KetQuaThucHien)
		{
			var q = from obj in provider.GetTable<LqVuViecXuLyEntity>()
                    where obj.KetQuaThucHien == KetQuaThucHien
                    select obj;
					
            LqVuViecXuLyEntity ob = (LqVuViecXuLyEntity)q.First<LqVuViecXuLyEntity>();
            provider.GetTable<LqVuViecXuLyEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdDonViXuLy(Guid IdDonViXuLy)
		{
			var q = from obj in provider.GetTable<LqVuViecXuLyEntity>()
                    where obj.IdDonViXuLy.Value == IdDonViXuLy
                    select obj;
					
            LqVuViecXuLyEntity ob = (LqVuViecXuLyEntity)q.First<LqVuViecXuLyEntity>();
            provider.GetTable<LqVuViecXuLyEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdHinhThucXuLy(Guid IdHinhThucXuLy)
		{
			var q = from obj in provider.GetTable<LqVuViecXuLyEntity>()
                    where obj.IdHinhThucXuLy.Value == IdHinhThucXuLy
                    select obj;
					
            LqVuViecXuLyEntity ob = (LqVuViecXuLyEntity)q.First<LqVuViecXuLyEntity>();
            provider.GetTable<LqVuViecXuLyEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteBySoHinhThucXuLy(string SoHinhThucXuLy)
		{
			var q = from obj in provider.GetTable<LqVuViecXuLyEntity>()
                    where obj.SoHinhThucXuLy == SoHinhThucXuLy
                    select obj;
					
            LqVuViecXuLyEntity ob = (LqVuViecXuLyEntity)q.First<LqVuViecXuLyEntity>();
            provider.GetTable<LqVuViecXuLyEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayXuLy(DateTime NgayXuLy)
		{
			var q = from obj in provider.GetTable<LqVuViecXuLyEntity>()
                    where obj.NgayXuLy.Value == NgayXuLy
                    select obj;
					
            LqVuViecXuLyEntity ob = (LqVuViecXuLyEntity)q.First<LqVuViecXuLyEntity>();
            provider.GetTable<LqVuViecXuLyEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayKetLuan(DateTime NgayKetLuan)
		{
			var q = from obj in provider.GetTable<LqVuViecXuLyEntity>()
                    where obj.NgayKetLuan.Value == NgayKetLuan
                    select obj;
					
            LqVuViecXuLyEntity ob = (LqVuViecXuLyEntity)q.First<LqVuViecXuLyEntity>();
            provider.GetTable<LqVuViecXuLyEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteBySoDinhChiTamDinhChi(string SoDinhChiTamDinhChi)
		{
			var q = from obj in provider.GetTable<LqVuViecXuLyEntity>()
                    where obj.SoDinhChiTamDinhChi == SoDinhChiTamDinhChi
                    select obj;
					
            LqVuViecXuLyEntity ob = (LqVuViecXuLyEntity)q.First<LqVuViecXuLyEntity>();
            provider.GetTable<LqVuViecXuLyEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayDinhChi(DateTime NgayDinhChi)
		{
			var q = from obj in provider.GetTable<LqVuViecXuLyEntity>()
                    where obj.NgayDinhChi.Value == NgayDinhChi
                    select obj;
					
            LqVuViecXuLyEntity ob = (LqVuViecXuLyEntity)q.First<LqVuViecXuLyEntity>();
            provider.GetTable<LqVuViecXuLyEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteBySoBanAn(string SoBanAn)
		{
			var q = from obj in provider.GetTable<LqVuViecXuLyEntity>()
                    where obj.SoBanAn == SoBanAn
                    select obj;
					
            LqVuViecXuLyEntity ob = (LqVuViecXuLyEntity)q.First<LqVuViecXuLyEntity>();
            provider.GetTable<LqVuViecXuLyEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayBanAn(DateTime NgayBanAn)
		{
			var q = from obj in provider.GetTable<LqVuViecXuLyEntity>()
                    where obj.NgayBanAn.Value == NgayBanAn
                    select obj;
					
            LqVuViecXuLyEntity ob = (LqVuViecXuLyEntity)q.First<LqVuViecXuLyEntity>();
            provider.GetTable<LqVuViecXuLyEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqVuViecXuLyEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqVuViecXuLyEntity ob = (LqVuViecXuLyEntity)q.First<LqVuViecXuLyEntity>();
            provider.GetTable<LqVuViecXuLyEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqVuViecXuLyEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqVuViecXuLyEntity ob = (LqVuViecXuLyEntity)q.First<LqVuViecXuLyEntity>();
            provider.GetTable<LqVuViecXuLyEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqVuViecXuLyEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqVuViecXuLyEntity ob = (LqVuViecXuLyEntity)q.First<LqVuViecXuLyEntity>();
            provider.GetTable<LqVuViecXuLyEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqVuViecXuLyEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqVuViecXuLyEntity ob = (LqVuViecXuLyEntity)q.First<LqVuViecXuLyEntity>();
            provider.GetTable<LqVuViecXuLyEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqVuViecXuLyEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqVuViecXuLyEntity ob = (LqVuViecXuLyEntity)q.First<LqVuViecXuLyEntity>();
            provider.GetTable<LqVuViecXuLyEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqVuViecXuLyEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqVuViecXuLyEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqVuViecXuLyEntity>();
		}

		public List<LqVuViecXuLyEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqVuViecXuLyEntity>()
                        select obj;
            return query.ToList<LqVuViecXuLyEntity>();
		}
		
		
		public List<LqVuViecXuLyEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqVuViecXuLyEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqVuViecXuLyEntity>();
		}
		
		
		public List<LqVuViecXuLyEntity> SelectByIdVuViec(Guid IdVuViec)
		{
			var query = from obj in provider.GetTable<LqVuViecXuLyEntity>()
                        where obj.IdVuViec == IdVuViec
                        select obj;
            return query.ToList<LqVuViecXuLyEntity>();
		}
		
		
		public List<LqVuViecXuLyEntity> SelectByIdCapChiDao(Guid IdCapChiDao)
		{
			var query = from obj in provider.GetTable<LqVuViecXuLyEntity>()
                        where obj.IdCapChiDao.Value == IdCapChiDao
                        select obj;
            return query.ToList<LqVuViecXuLyEntity>();
		}
		
		
		public List<LqVuViecXuLyEntity> SelectByNoiDung(string NoiDung)
		{
			var query = from obj in provider.GetTable<LqVuViecXuLyEntity>()
                        where obj.NoiDung == NoiDung
                        select obj;
            return query.ToList<LqVuViecXuLyEntity>();
		}
		
		
		public List<LqVuViecXuLyEntity> SelectByKetQuaThucHien(string KetQuaThucHien)
		{
			var query = from obj in provider.GetTable<LqVuViecXuLyEntity>()
                        where obj.KetQuaThucHien == KetQuaThucHien
                        select obj;
            return query.ToList<LqVuViecXuLyEntity>();
		}
		
		
		public List<LqVuViecXuLyEntity> SelectByIdDonViXuLy(Guid IdDonViXuLy)
		{
			var query = from obj in provider.GetTable<LqVuViecXuLyEntity>()
                        where obj.IdDonViXuLy.Value == IdDonViXuLy
                        select obj;
            return query.ToList<LqVuViecXuLyEntity>();
		}
		
		
		public List<LqVuViecXuLyEntity> SelectByIdHinhThucXuLy(Guid IdHinhThucXuLy)
		{
			var query = from obj in provider.GetTable<LqVuViecXuLyEntity>()
                        where obj.IdHinhThucXuLy.Value == IdHinhThucXuLy
                        select obj;
            return query.ToList<LqVuViecXuLyEntity>();
		}
		
		
		public List<LqVuViecXuLyEntity> SelectBySoHinhThucXuLy(string SoHinhThucXuLy)
		{
			var query = from obj in provider.GetTable<LqVuViecXuLyEntity>()
                        where obj.SoHinhThucXuLy == SoHinhThucXuLy
                        select obj;
            return query.ToList<LqVuViecXuLyEntity>();
		}
		
		
		public List<LqVuViecXuLyEntity> SelectByNgayXuLy(DateTime NgayXuLy)
		{
			var query = from obj in provider.GetTable<LqVuViecXuLyEntity>()
                        where obj.NgayXuLy.Value == NgayXuLy
                        select obj;
            return query.ToList<LqVuViecXuLyEntity>();
		}
		
		
		public List<LqVuViecXuLyEntity> SelectByNgayKetLuan(DateTime NgayKetLuan)
		{
			var query = from obj in provider.GetTable<LqVuViecXuLyEntity>()
                        where obj.NgayKetLuan.Value == NgayKetLuan
                        select obj;
            return query.ToList<LqVuViecXuLyEntity>();
		}
		
		
		public List<LqVuViecXuLyEntity> SelectBySoDinhChiTamDinhChi(string SoDinhChiTamDinhChi)
		{
			var query = from obj in provider.GetTable<LqVuViecXuLyEntity>()
                        where obj.SoDinhChiTamDinhChi == SoDinhChiTamDinhChi
                        select obj;
            return query.ToList<LqVuViecXuLyEntity>();
		}
		
		
		public List<LqVuViecXuLyEntity> SelectByNgayDinhChi(DateTime NgayDinhChi)
		{
			var query = from obj in provider.GetTable<LqVuViecXuLyEntity>()
                        where obj.NgayDinhChi.Value == NgayDinhChi
                        select obj;
            return query.ToList<LqVuViecXuLyEntity>();
		}
		
		
		public List<LqVuViecXuLyEntity> SelectBySoBanAn(string SoBanAn)
		{
			var query = from obj in provider.GetTable<LqVuViecXuLyEntity>()
                        where obj.SoBanAn == SoBanAn
                        select obj;
            return query.ToList<LqVuViecXuLyEntity>();
		}
		
		
		public List<LqVuViecXuLyEntity> SelectByNgayBanAn(DateTime NgayBanAn)
		{
			var query = from obj in provider.GetTable<LqVuViecXuLyEntity>()
                        where obj.NgayBanAn.Value == NgayBanAn
                        select obj;
            return query.ToList<LqVuViecXuLyEntity>();
		}
		
		
		public List<LqVuViecXuLyEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqVuViecXuLyEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqVuViecXuLyEntity>();
		}
		
		
		public List<LqVuViecXuLyEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqVuViecXuLyEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqVuViecXuLyEntity>();
		}
		
		
		public List<LqVuViecXuLyEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqVuViecXuLyEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqVuViecXuLyEntity>();
		}
		
		
		public List<LqVuViecXuLyEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqVuViecXuLyEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqVuViecXuLyEntity>();
		}
		
		
		public List<LqVuViecXuLyEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqVuViecXuLyEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqVuViecXuLyEntity>();
		}
		
		
		

	}
}
