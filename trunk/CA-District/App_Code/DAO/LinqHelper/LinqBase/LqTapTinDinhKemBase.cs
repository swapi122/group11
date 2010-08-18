




/*
'===============================================================================
'  LinqHelper.DAO.TapTinDinhKemBase
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
	public class LqTapTinDinhKemBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqTapTinDinhKemBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqTapTinDinhKemEntity obj)
		{
			provider.GetTable<LqTapTinDinhKemEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqTapTinDinhKemEntity _obj)
		{
			var q = from obj in provider.GetTable<LqTapTinDinhKemEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqTapTinDinhKemEntity tmp = q.First<LqTapTinDinhKemEntity>();
			
			tmp.IdVuViec = _obj.IdVuViec;
			tmp.TenTapTinDinhKem = _obj.TenTapTinDinhKem;
			tmp.IdLoaiTapTin = _obj.IdLoaiTapTin;
			tmp.DuongDan = _obj.DuongDan;
			tmp.MoTa = _obj.MoTa;
			tmp.IdNguoiTao = _obj.IdNguoiTao;
			tmp.NgayTao = _obj.NgayTao;
			tmp.IdNguoiCapNhat = _obj.IdNguoiCapNhat;
			tmp.NgayCapNhat = _obj.NgayCapNhat;
			tmp.TrangThai = _obj.TrangThai;
		}
		
		public void Delete(LqTapTinDinhKemEntity obj)
		{
			provider.GetTable<LqTapTinDinhKemEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqTapTinDinhKemEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqTapTinDinhKemEntity ob = (LqTapTinDinhKemEntity)q.First<LqTapTinDinhKemEntity>();
            provider.GetTable<LqTapTinDinhKemEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdVuViec(Guid IdVuViec)
		{
			var q = from obj in provider.GetTable<LqTapTinDinhKemEntity>()
                    where obj.IdVuViec == IdVuViec
                    select obj;
					
            LqTapTinDinhKemEntity ob = (LqTapTinDinhKemEntity)q.First<LqTapTinDinhKemEntity>();
            provider.GetTable<LqTapTinDinhKemEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTenTapTinDinhKem(string TenTapTinDinhKem)
		{
			var q = from obj in provider.GetTable<LqTapTinDinhKemEntity>()
                    where obj.TenTapTinDinhKem == TenTapTinDinhKem
                    select obj;
					
            LqTapTinDinhKemEntity ob = (LqTapTinDinhKemEntity)q.First<LqTapTinDinhKemEntity>();
            provider.GetTable<LqTapTinDinhKemEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdLoaiTapTin(Guid IdLoaiTapTin)
		{
			var q = from obj in provider.GetTable<LqTapTinDinhKemEntity>()
                    where obj.IdLoaiTapTin.Value == IdLoaiTapTin
                    select obj;
					
            LqTapTinDinhKemEntity ob = (LqTapTinDinhKemEntity)q.First<LqTapTinDinhKemEntity>();
            provider.GetTable<LqTapTinDinhKemEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByDuongDan(string DuongDan)
		{
			var q = from obj in provider.GetTable<LqTapTinDinhKemEntity>()
                    where obj.DuongDan == DuongDan
                    select obj;
					
            LqTapTinDinhKemEntity ob = (LqTapTinDinhKemEntity)q.First<LqTapTinDinhKemEntity>();
            provider.GetTable<LqTapTinDinhKemEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMoTa(string MoTa)
		{
			var q = from obj in provider.GetTable<LqTapTinDinhKemEntity>()
                    where obj.MoTa == MoTa
                    select obj;
					
            LqTapTinDinhKemEntity ob = (LqTapTinDinhKemEntity)q.First<LqTapTinDinhKemEntity>();
            provider.GetTable<LqTapTinDinhKemEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqTapTinDinhKemEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqTapTinDinhKemEntity ob = (LqTapTinDinhKemEntity)q.First<LqTapTinDinhKemEntity>();
            provider.GetTable<LqTapTinDinhKemEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqTapTinDinhKemEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqTapTinDinhKemEntity ob = (LqTapTinDinhKemEntity)q.First<LqTapTinDinhKemEntity>();
            provider.GetTable<LqTapTinDinhKemEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqTapTinDinhKemEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqTapTinDinhKemEntity ob = (LqTapTinDinhKemEntity)q.First<LqTapTinDinhKemEntity>();
            provider.GetTable<LqTapTinDinhKemEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqTapTinDinhKemEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqTapTinDinhKemEntity ob = (LqTapTinDinhKemEntity)q.First<LqTapTinDinhKemEntity>();
            provider.GetTable<LqTapTinDinhKemEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqTapTinDinhKemEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqTapTinDinhKemEntity ob = (LqTapTinDinhKemEntity)q.First<LqTapTinDinhKemEntity>();
            provider.GetTable<LqTapTinDinhKemEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqTapTinDinhKemEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqTapTinDinhKemEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqTapTinDinhKemEntity>();
		}

		public List<LqTapTinDinhKemEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqTapTinDinhKemEntity>()
                        select obj;
            return query.ToList<LqTapTinDinhKemEntity>();
		}
		
		
		public List<LqTapTinDinhKemEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqTapTinDinhKemEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqTapTinDinhKemEntity>();
		}
		
		
		public List<LqTapTinDinhKemEntity> SelectByIdVuViec(Guid IdVuViec)
		{
			var query = from obj in provider.GetTable<LqTapTinDinhKemEntity>()
                        where obj.IdVuViec == IdVuViec
                        select obj;
            return query.ToList<LqTapTinDinhKemEntity>();
		}
		
		
		public List<LqTapTinDinhKemEntity> SelectByTenTapTinDinhKem(string TenTapTinDinhKem)
		{
			var query = from obj in provider.GetTable<LqTapTinDinhKemEntity>()
                        where obj.TenTapTinDinhKem == TenTapTinDinhKem
                        select obj;
            return query.ToList<LqTapTinDinhKemEntity>();
		}
		
		
		public List<LqTapTinDinhKemEntity> SelectByIdLoaiTapTin(Guid IdLoaiTapTin)
		{
			var query = from obj in provider.GetTable<LqTapTinDinhKemEntity>()
                        where obj.IdLoaiTapTin.Value == IdLoaiTapTin
                        select obj;
            return query.ToList<LqTapTinDinhKemEntity>();
		}
		
		
		public List<LqTapTinDinhKemEntity> SelectByDuongDan(string DuongDan)
		{
			var query = from obj in provider.GetTable<LqTapTinDinhKemEntity>()
                        where obj.DuongDan == DuongDan
                        select obj;
            return query.ToList<LqTapTinDinhKemEntity>();
		}
		
		
		public List<LqTapTinDinhKemEntity> SelectByMoTa(string MoTa)
		{
			var query = from obj in provider.GetTable<LqTapTinDinhKemEntity>()
                        where obj.MoTa == MoTa
                        select obj;
            return query.ToList<LqTapTinDinhKemEntity>();
		}
		
		
		public List<LqTapTinDinhKemEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqTapTinDinhKemEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqTapTinDinhKemEntity>();
		}
		
		
		public List<LqTapTinDinhKemEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqTapTinDinhKemEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqTapTinDinhKemEntity>();
		}
		
		
		public List<LqTapTinDinhKemEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqTapTinDinhKemEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqTapTinDinhKemEntity>();
		}
		
		
		public List<LqTapTinDinhKemEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqTapTinDinhKemEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqTapTinDinhKemEntity>();
		}
		
		
		public List<LqTapTinDinhKemEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqTapTinDinhKemEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqTapTinDinhKemEntity>();
		}
		
		
		

	}
}
