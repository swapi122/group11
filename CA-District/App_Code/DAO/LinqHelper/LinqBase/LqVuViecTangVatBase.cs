




/*
'===============================================================================
'  LinqHelper.DAO.VuViecTangVatBase
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
	public class LqVuViecTangVatBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqVuViecTangVatBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqVuViecTangVatEntity obj)
		{
			provider.GetTable<LqVuViecTangVatEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqVuViecTangVatEntity _obj)
		{
			var q = from obj in provider.GetTable<LqVuViecTangVatEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqVuViecTangVatEntity tmp = q.First<LqVuViecTangVatEntity>();
			
			tmp.IdVuViec = _obj.IdVuViec;
			tmp.IdTangVat = _obj.IdTangVat;
			tmp.GiaTriTangVat = _obj.GiaTriTangVat;
			tmp.IdLoaiTien = _obj.IdLoaiTien;
			tmp.GhiChu = _obj.GhiChu;
			tmp.IdNguoiTao = _obj.IdNguoiTao;
			tmp.NgayTao = _obj.NgayTao;
			tmp.IdNguoiCapNhat = _obj.IdNguoiCapNhat;
			tmp.NgayCapNhat = _obj.NgayCapNhat;
			tmp.TrangThai = _obj.TrangThai;
		}
		
		public void Delete(LqVuViecTangVatEntity obj)
		{
			provider.GetTable<LqVuViecTangVatEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqVuViecTangVatEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqVuViecTangVatEntity ob = (LqVuViecTangVatEntity)q.First<LqVuViecTangVatEntity>();
            provider.GetTable<LqVuViecTangVatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdVuViec(Guid IdVuViec)
		{
			var q = from obj in provider.GetTable<LqVuViecTangVatEntity>()
                    where obj.IdVuViec == IdVuViec
                    select obj;
					
            LqVuViecTangVatEntity ob = (LqVuViecTangVatEntity)q.First<LqVuViecTangVatEntity>();
            provider.GetTable<LqVuViecTangVatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdTangVat(Guid IdTangVat)
		{
			var q = from obj in provider.GetTable<LqVuViecTangVatEntity>()
                    where obj.IdTangVat.Value == IdTangVat
                    select obj;
					
            LqVuViecTangVatEntity ob = (LqVuViecTangVatEntity)q.First<LqVuViecTangVatEntity>();
            provider.GetTable<LqVuViecTangVatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGiaTriTangVat(decimal GiaTriTangVat)
		{
			var q = from obj in provider.GetTable<LqVuViecTangVatEntity>()
                    where obj.GiaTriTangVat.Value == GiaTriTangVat
                    select obj;
					
            LqVuViecTangVatEntity ob = (LqVuViecTangVatEntity)q.First<LqVuViecTangVatEntity>();
            provider.GetTable<LqVuViecTangVatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdLoaiTien(Guid IdLoaiTien)
		{
			var q = from obj in provider.GetTable<LqVuViecTangVatEntity>()
                    where obj.IdLoaiTien.Value == IdLoaiTien
                    select obj;
					
            LqVuViecTangVatEntity ob = (LqVuViecTangVatEntity)q.First<LqVuViecTangVatEntity>();
            provider.GetTable<LqVuViecTangVatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGhiChu(string GhiChu)
		{
			var q = from obj in provider.GetTable<LqVuViecTangVatEntity>()
                    where obj.GhiChu == GhiChu
                    select obj;
					
            LqVuViecTangVatEntity ob = (LqVuViecTangVatEntity)q.First<LqVuViecTangVatEntity>();
            provider.GetTable<LqVuViecTangVatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqVuViecTangVatEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqVuViecTangVatEntity ob = (LqVuViecTangVatEntity)q.First<LqVuViecTangVatEntity>();
            provider.GetTable<LqVuViecTangVatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqVuViecTangVatEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqVuViecTangVatEntity ob = (LqVuViecTangVatEntity)q.First<LqVuViecTangVatEntity>();
            provider.GetTable<LqVuViecTangVatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqVuViecTangVatEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqVuViecTangVatEntity ob = (LqVuViecTangVatEntity)q.First<LqVuViecTangVatEntity>();
            provider.GetTable<LqVuViecTangVatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqVuViecTangVatEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqVuViecTangVatEntity ob = (LqVuViecTangVatEntity)q.First<LqVuViecTangVatEntity>();
            provider.GetTable<LqVuViecTangVatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqVuViecTangVatEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqVuViecTangVatEntity ob = (LqVuViecTangVatEntity)q.First<LqVuViecTangVatEntity>();
            provider.GetTable<LqVuViecTangVatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqVuViecTangVatEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqVuViecTangVatEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqVuViecTangVatEntity>();
		}

		public List<LqVuViecTangVatEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqVuViecTangVatEntity>()
                        select obj;
            return query.ToList<LqVuViecTangVatEntity>();
		}
		
		
		public List<LqVuViecTangVatEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqVuViecTangVatEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqVuViecTangVatEntity>();
		}
		
		
		public List<LqVuViecTangVatEntity> SelectByIdVuViec(Guid IdVuViec)
		{
			var query = from obj in provider.GetTable<LqVuViecTangVatEntity>()
                        where obj.IdVuViec == IdVuViec
                        select obj;
            return query.ToList<LqVuViecTangVatEntity>();
		}
		
		
		public List<LqVuViecTangVatEntity> SelectByIdTangVat(Guid IdTangVat)
		{
			var query = from obj in provider.GetTable<LqVuViecTangVatEntity>()
                        where obj.IdTangVat.Value == IdTangVat
                        select obj;
            return query.ToList<LqVuViecTangVatEntity>();
		}
		
		
		public List<LqVuViecTangVatEntity> SelectByGiaTriTangVat(decimal GiaTriTangVat)
		{
			var query = from obj in provider.GetTable<LqVuViecTangVatEntity>()
                        where obj.GiaTriTangVat.Value == GiaTriTangVat
                        select obj;
            return query.ToList<LqVuViecTangVatEntity>();
		}
		
		
		public List<LqVuViecTangVatEntity> SelectByIdLoaiTien(Guid IdLoaiTien)
		{
			var query = from obj in provider.GetTable<LqVuViecTangVatEntity>()
                        where obj.IdLoaiTien.Value == IdLoaiTien
                        select obj;
            return query.ToList<LqVuViecTangVatEntity>();
		}
		
		
		public List<LqVuViecTangVatEntity> SelectByGhiChu(string GhiChu)
		{
			var query = from obj in provider.GetTable<LqVuViecTangVatEntity>()
                        where obj.GhiChu == GhiChu
                        select obj;
            return query.ToList<LqVuViecTangVatEntity>();
		}
		
		
		public List<LqVuViecTangVatEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqVuViecTangVatEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqVuViecTangVatEntity>();
		}
		
		
		public List<LqVuViecTangVatEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqVuViecTangVatEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqVuViecTangVatEntity>();
		}
		
		
		public List<LqVuViecTangVatEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqVuViecTangVatEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqVuViecTangVatEntity>();
		}
		
		
		public List<LqVuViecTangVatEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqVuViecTangVatEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqVuViecTangVatEntity>();
		}
		
		
		public List<LqVuViecTangVatEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqVuViecTangVatEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqVuViecTangVatEntity>();
		}
		
		
		

	}
}
