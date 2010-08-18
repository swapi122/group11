




/*
'===============================================================================
'  LinqHelper.DAO.NanNhanVuViecBase
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
	public class LqNanNhanVuViecBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqNanNhanVuViecBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqNanNhanVuViecEntity obj)
		{
			provider.GetTable<LqNanNhanVuViecEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqNanNhanVuViecEntity _obj)
		{
			var q = from obj in provider.GetTable<LqNanNhanVuViecEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqNanNhanVuViecEntity tmp = q.First<LqNanNhanVuViecEntity>();
			
			tmp.IdVuViec = _obj.IdVuViec;
			tmp.IdNanNhan = _obj.IdNanNhan;
			tmp.MaRutGon = _obj.MaRutGon;
			tmp.MaTp = _obj.MaTp;
			tmp.GhiChu = _obj.GhiChu;
			tmp.IdNguoiTao = _obj.IdNguoiTao;
			tmp.NgayTao = _obj.NgayTao;
			tmp.IdNguoiCapNhat = _obj.IdNguoiCapNhat;
			tmp.NgayCapNhat = _obj.NgayCapNhat;
			tmp.TrangThai = _obj.TrangThai;
		}
		
		public void Delete(LqNanNhanVuViecEntity obj)
		{
			provider.GetTable<LqNanNhanVuViecEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqNanNhanVuViecEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqNanNhanVuViecEntity ob = (LqNanNhanVuViecEntity)q.First<LqNanNhanVuViecEntity>();
            provider.GetTable<LqNanNhanVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdVuViec(Guid IdVuViec)
		{
			var q = from obj in provider.GetTable<LqNanNhanVuViecEntity>()
                    where obj.IdVuViec == IdVuViec
                    select obj;
					
            LqNanNhanVuViecEntity ob = (LqNanNhanVuViecEntity)q.First<LqNanNhanVuViecEntity>();
            provider.GetTable<LqNanNhanVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNanNhan(Guid IdNanNhan)
		{
			var q = from obj in provider.GetTable<LqNanNhanVuViecEntity>()
                    where obj.IdNanNhan == IdNanNhan
                    select obj;
					
            LqNanNhanVuViecEntity ob = (LqNanNhanVuViecEntity)q.First<LqNanNhanVuViecEntity>();
            provider.GetTable<LqNanNhanVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqNanNhanVuViecEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqNanNhanVuViecEntity ob = (LqNanNhanVuViecEntity)q.First<LqNanNhanVuViecEntity>();
            provider.GetTable<LqNanNhanVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaTp(string MaTp)
		{
			var q = from obj in provider.GetTable<LqNanNhanVuViecEntity>()
                    where obj.MaTp == MaTp
                    select obj;
					
            LqNanNhanVuViecEntity ob = (LqNanNhanVuViecEntity)q.First<LqNanNhanVuViecEntity>();
            provider.GetTable<LqNanNhanVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGhiChu(string GhiChu)
		{
			var q = from obj in provider.GetTable<LqNanNhanVuViecEntity>()
                    where obj.GhiChu == GhiChu
                    select obj;
					
            LqNanNhanVuViecEntity ob = (LqNanNhanVuViecEntity)q.First<LqNanNhanVuViecEntity>();
            provider.GetTable<LqNanNhanVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqNanNhanVuViecEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqNanNhanVuViecEntity ob = (LqNanNhanVuViecEntity)q.First<LqNanNhanVuViecEntity>();
            provider.GetTable<LqNanNhanVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqNanNhanVuViecEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqNanNhanVuViecEntity ob = (LqNanNhanVuViecEntity)q.First<LqNanNhanVuViecEntity>();
            provider.GetTable<LqNanNhanVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqNanNhanVuViecEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqNanNhanVuViecEntity ob = (LqNanNhanVuViecEntity)q.First<LqNanNhanVuViecEntity>();
            provider.GetTable<LqNanNhanVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqNanNhanVuViecEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqNanNhanVuViecEntity ob = (LqNanNhanVuViecEntity)q.First<LqNanNhanVuViecEntity>();
            provider.GetTable<LqNanNhanVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqNanNhanVuViecEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqNanNhanVuViecEntity ob = (LqNanNhanVuViecEntity)q.First<LqNanNhanVuViecEntity>();
            provider.GetTable<LqNanNhanVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqNanNhanVuViecEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqNanNhanVuViecEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqNanNhanVuViecEntity>();
		}

		public List<LqNanNhanVuViecEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqNanNhanVuViecEntity>()
                        select obj;
            return query.ToList<LqNanNhanVuViecEntity>();
		}
		
		
		public List<LqNanNhanVuViecEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqNanNhanVuViecEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqNanNhanVuViecEntity>();
		}
		
		
		public List<LqNanNhanVuViecEntity> SelectByIdVuViec(Guid IdVuViec)
		{
			var query = from obj in provider.GetTable<LqNanNhanVuViecEntity>()
                        where obj.IdVuViec == IdVuViec
                        select obj;
            return query.ToList<LqNanNhanVuViecEntity>();
		}
		
		
		public List<LqNanNhanVuViecEntity> SelectByIdNanNhan(Guid IdNanNhan)
		{
			var query = from obj in provider.GetTable<LqNanNhanVuViecEntity>()
                        where obj.IdNanNhan == IdNanNhan
                        select obj;
            return query.ToList<LqNanNhanVuViecEntity>();
		}
		
		
		public List<LqNanNhanVuViecEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqNanNhanVuViecEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqNanNhanVuViecEntity>();
		}
		
		
		public List<LqNanNhanVuViecEntity> SelectByMaTp(string MaTp)
		{
			var query = from obj in provider.GetTable<LqNanNhanVuViecEntity>()
                        where obj.MaTp == MaTp
                        select obj;
            return query.ToList<LqNanNhanVuViecEntity>();
		}
		
		
		public List<LqNanNhanVuViecEntity> SelectByGhiChu(string GhiChu)
		{
			var query = from obj in provider.GetTable<LqNanNhanVuViecEntity>()
                        where obj.GhiChu == GhiChu
                        select obj;
            return query.ToList<LqNanNhanVuViecEntity>();
		}
		
		
		public List<LqNanNhanVuViecEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqNanNhanVuViecEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqNanNhanVuViecEntity>();
		}
		
		
		public List<LqNanNhanVuViecEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqNanNhanVuViecEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqNanNhanVuViecEntity>();
		}
		
		
		public List<LqNanNhanVuViecEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqNanNhanVuViecEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqNanNhanVuViecEntity>();
		}
		
		
		public List<LqNanNhanVuViecEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqNanNhanVuViecEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqNanNhanVuViecEntity>();
		}
		
		
		public List<LqNanNhanVuViecEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqNanNhanVuViecEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqNanNhanVuViecEntity>();
		}
		
		
		

	}
}
