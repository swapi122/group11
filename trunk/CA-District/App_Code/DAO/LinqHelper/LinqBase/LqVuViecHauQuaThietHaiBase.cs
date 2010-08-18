




/*
'===============================================================================
'  LinqHelper.DAO.VuViecHauQuaThietHaiBase
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
	public class LqVuViecHauQuaThietHaiBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqVuViecHauQuaThietHaiBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqVuViecHauQuaThietHaiEntity obj)
		{
			provider.GetTable<LqVuViecHauQuaThietHaiEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqVuViecHauQuaThietHaiEntity _obj)
		{
			var q = from obj in provider.GetTable<LqVuViecHauQuaThietHaiEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqVuViecHauQuaThietHaiEntity tmp = q.First<LqVuViecHauQuaThietHaiEntity>();
			
			tmp.IdVuViec = _obj.IdVuViec;
			tmp.IdThietHai = _obj.IdThietHai;
			tmp.IdDonViTinh = _obj.IdDonViTinh;
			tmp.SoLuong = _obj.SoLuong;
			tmp.GiaTriThietHai = _obj.GiaTriThietHai;
			tmp.GhiChu = _obj.GhiChu;
			tmp.IdLoaiTien = _obj.IdLoaiTien;
			tmp.MaRutGon = _obj.MaRutGon;
			tmp.IdNguoiTao = _obj.IdNguoiTao;
			tmp.NgayTao = _obj.NgayTao;
			tmp.IdNguoiCapNhat = _obj.IdNguoiCapNhat;
			tmp.NgayCapNhat = _obj.NgayCapNhat;
			tmp.TrangThai = _obj.TrangThai;
		}
		
		public void Delete(LqVuViecHauQuaThietHaiEntity obj)
		{
			provider.GetTable<LqVuViecHauQuaThietHaiEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqVuViecHauQuaThietHaiEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqVuViecHauQuaThietHaiEntity ob = (LqVuViecHauQuaThietHaiEntity)q.First<LqVuViecHauQuaThietHaiEntity>();
            provider.GetTable<LqVuViecHauQuaThietHaiEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdVuViec(Guid IdVuViec)
		{
			var q = from obj in provider.GetTable<LqVuViecHauQuaThietHaiEntity>()
                    where obj.IdVuViec == IdVuViec
                    select obj;
					
            LqVuViecHauQuaThietHaiEntity ob = (LqVuViecHauQuaThietHaiEntity)q.First<LqVuViecHauQuaThietHaiEntity>();
            provider.GetTable<LqVuViecHauQuaThietHaiEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdThietHai(Guid IdThietHai)
		{
			var q = from obj in provider.GetTable<LqVuViecHauQuaThietHaiEntity>()
                    where obj.IdThietHai.Value == IdThietHai
                    select obj;
					
            LqVuViecHauQuaThietHaiEntity ob = (LqVuViecHauQuaThietHaiEntity)q.First<LqVuViecHauQuaThietHaiEntity>();
            provider.GetTable<LqVuViecHauQuaThietHaiEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdDonViTinh(Guid IdDonViTinh)
		{
			var q = from obj in provider.GetTable<LqVuViecHauQuaThietHaiEntity>()
                    where obj.IdDonViTinh.Value == IdDonViTinh
                    select obj;
					
            LqVuViecHauQuaThietHaiEntity ob = (LqVuViecHauQuaThietHaiEntity)q.First<LqVuViecHauQuaThietHaiEntity>();
            provider.GetTable<LqVuViecHauQuaThietHaiEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteBySoLuong(int SoLuong)
		{
			var q = from obj in provider.GetTable<LqVuViecHauQuaThietHaiEntity>()
                    where obj.SoLuong.Value == SoLuong
                    select obj;
					
            LqVuViecHauQuaThietHaiEntity ob = (LqVuViecHauQuaThietHaiEntity)q.First<LqVuViecHauQuaThietHaiEntity>();
            provider.GetTable<LqVuViecHauQuaThietHaiEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGiaTriThietHai(decimal GiaTriThietHai)
		{
			var q = from obj in provider.GetTable<LqVuViecHauQuaThietHaiEntity>()
                    where obj.GiaTriThietHai.Value == GiaTriThietHai
                    select obj;
					
            LqVuViecHauQuaThietHaiEntity ob = (LqVuViecHauQuaThietHaiEntity)q.First<LqVuViecHauQuaThietHaiEntity>();
            provider.GetTable<LqVuViecHauQuaThietHaiEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGhiChu(string GhiChu)
		{
			var q = from obj in provider.GetTable<LqVuViecHauQuaThietHaiEntity>()
                    where obj.GhiChu == GhiChu
                    select obj;
					
            LqVuViecHauQuaThietHaiEntity ob = (LqVuViecHauQuaThietHaiEntity)q.First<LqVuViecHauQuaThietHaiEntity>();
            provider.GetTable<LqVuViecHauQuaThietHaiEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdLoaiTien(Guid IdLoaiTien)
		{
			var q = from obj in provider.GetTable<LqVuViecHauQuaThietHaiEntity>()
                    where obj.IdLoaiTien.Value == IdLoaiTien
                    select obj;
					
            LqVuViecHauQuaThietHaiEntity ob = (LqVuViecHauQuaThietHaiEntity)q.First<LqVuViecHauQuaThietHaiEntity>();
            provider.GetTable<LqVuViecHauQuaThietHaiEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqVuViecHauQuaThietHaiEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqVuViecHauQuaThietHaiEntity ob = (LqVuViecHauQuaThietHaiEntity)q.First<LqVuViecHauQuaThietHaiEntity>();
            provider.GetTable<LqVuViecHauQuaThietHaiEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqVuViecHauQuaThietHaiEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqVuViecHauQuaThietHaiEntity ob = (LqVuViecHauQuaThietHaiEntity)q.First<LqVuViecHauQuaThietHaiEntity>();
            provider.GetTable<LqVuViecHauQuaThietHaiEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqVuViecHauQuaThietHaiEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqVuViecHauQuaThietHaiEntity ob = (LqVuViecHauQuaThietHaiEntity)q.First<LqVuViecHauQuaThietHaiEntity>();
            provider.GetTable<LqVuViecHauQuaThietHaiEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqVuViecHauQuaThietHaiEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqVuViecHauQuaThietHaiEntity ob = (LqVuViecHauQuaThietHaiEntity)q.First<LqVuViecHauQuaThietHaiEntity>();
            provider.GetTable<LqVuViecHauQuaThietHaiEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqVuViecHauQuaThietHaiEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqVuViecHauQuaThietHaiEntity ob = (LqVuViecHauQuaThietHaiEntity)q.First<LqVuViecHauQuaThietHaiEntity>();
            provider.GetTable<LqVuViecHauQuaThietHaiEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqVuViecHauQuaThietHaiEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqVuViecHauQuaThietHaiEntity ob = (LqVuViecHauQuaThietHaiEntity)q.First<LqVuViecHauQuaThietHaiEntity>();
            provider.GetTable<LqVuViecHauQuaThietHaiEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqVuViecHauQuaThietHaiEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqVuViecHauQuaThietHaiEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqVuViecHauQuaThietHaiEntity>();
		}

		public List<LqVuViecHauQuaThietHaiEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqVuViecHauQuaThietHaiEntity>()
                        select obj;
            return query.ToList<LqVuViecHauQuaThietHaiEntity>();
		}
		
		
		public List<LqVuViecHauQuaThietHaiEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqVuViecHauQuaThietHaiEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqVuViecHauQuaThietHaiEntity>();
		}
		
		
		public List<LqVuViecHauQuaThietHaiEntity> SelectByIdVuViec(Guid IdVuViec)
		{
			var query = from obj in provider.GetTable<LqVuViecHauQuaThietHaiEntity>()
                        where obj.IdVuViec == IdVuViec
                        select obj;
            return query.ToList<LqVuViecHauQuaThietHaiEntity>();
		}
		
		
		public List<LqVuViecHauQuaThietHaiEntity> SelectByIdThietHai(Guid IdThietHai)
		{
			var query = from obj in provider.GetTable<LqVuViecHauQuaThietHaiEntity>()
                        where obj.IdThietHai.Value == IdThietHai
                        select obj;
            return query.ToList<LqVuViecHauQuaThietHaiEntity>();
		}
		
		
		public List<LqVuViecHauQuaThietHaiEntity> SelectByIdDonViTinh(Guid IdDonViTinh)
		{
			var query = from obj in provider.GetTable<LqVuViecHauQuaThietHaiEntity>()
                        where obj.IdDonViTinh.Value == IdDonViTinh
                        select obj;
            return query.ToList<LqVuViecHauQuaThietHaiEntity>();
		}
		
		
		public List<LqVuViecHauQuaThietHaiEntity> SelectBySoLuong(int SoLuong)
		{
			var query = from obj in provider.GetTable<LqVuViecHauQuaThietHaiEntity>()
                        where obj.SoLuong.Value == SoLuong
                        select obj;
            return query.ToList<LqVuViecHauQuaThietHaiEntity>();
		}
		
		
		public List<LqVuViecHauQuaThietHaiEntity> SelectByGiaTriThietHai(decimal GiaTriThietHai)
		{
			var query = from obj in provider.GetTable<LqVuViecHauQuaThietHaiEntity>()
                        where obj.GiaTriThietHai.Value == GiaTriThietHai
                        select obj;
            return query.ToList<LqVuViecHauQuaThietHaiEntity>();
		}
		
		
		public List<LqVuViecHauQuaThietHaiEntity> SelectByGhiChu(string GhiChu)
		{
			var query = from obj in provider.GetTable<LqVuViecHauQuaThietHaiEntity>()
                        where obj.GhiChu == GhiChu
                        select obj;
            return query.ToList<LqVuViecHauQuaThietHaiEntity>();
		}
		
		
		public List<LqVuViecHauQuaThietHaiEntity> SelectByIdLoaiTien(Guid IdLoaiTien)
		{
			var query = from obj in provider.GetTable<LqVuViecHauQuaThietHaiEntity>()
                        where obj.IdLoaiTien.Value == IdLoaiTien
                        select obj;
            return query.ToList<LqVuViecHauQuaThietHaiEntity>();
		}
		
		
		public List<LqVuViecHauQuaThietHaiEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqVuViecHauQuaThietHaiEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqVuViecHauQuaThietHaiEntity>();
		}
		
		
		public List<LqVuViecHauQuaThietHaiEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqVuViecHauQuaThietHaiEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqVuViecHauQuaThietHaiEntity>();
		}
		
		
		public List<LqVuViecHauQuaThietHaiEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqVuViecHauQuaThietHaiEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqVuViecHauQuaThietHaiEntity>();
		}
		
		
		public List<LqVuViecHauQuaThietHaiEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqVuViecHauQuaThietHaiEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqVuViecHauQuaThietHaiEntity>();
		}
		
		
		public List<LqVuViecHauQuaThietHaiEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqVuViecHauQuaThietHaiEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqVuViecHauQuaThietHaiEntity>();
		}
		
		
		public List<LqVuViecHauQuaThietHaiEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqVuViecHauQuaThietHaiEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqVuViecHauQuaThietHaiEntity>();
		}
		
		
		

	}
}
