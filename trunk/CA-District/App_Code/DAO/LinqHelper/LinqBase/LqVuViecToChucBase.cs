




/*
'===============================================================================
'  LinqHelper.DAO.VuViecToChucBase
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
	public class LqVuViecToChucBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqVuViecToChucBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqVuViecToChucEntity obj)
		{
			provider.GetTable<LqVuViecToChucEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqVuViecToChucEntity _obj)
		{
			var q = from obj in provider.GetTable<LqVuViecToChucEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqVuViecToChucEntity tmp = q.First<LqVuViecToChucEntity>();
			
			tmp.IdVuViec = _obj.IdVuViec;
			tmp.IdToChuc = _obj.IdToChuc;
			tmp.MaRutGon = _obj.MaRutGon;
			tmp.MaTp = _obj.MaTp;
			tmp.GhiChu = _obj.GhiChu;
			tmp.IdNguoiTao = _obj.IdNguoiTao;
			tmp.NgayTao = _obj.NgayTao;
			tmp.IdNguoiCapNhat = _obj.IdNguoiCapNhat;
			tmp.NgayCapNhat = _obj.NgayCapNhat;
			tmp.TrangThai = _obj.TrangThai;
		}
		
		public void Delete(LqVuViecToChucEntity obj)
		{
			provider.GetTable<LqVuViecToChucEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqVuViecToChucEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqVuViecToChucEntity ob = (LqVuViecToChucEntity)q.First<LqVuViecToChucEntity>();
            provider.GetTable<LqVuViecToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdVuViec(Guid IdVuViec)
		{
			var q = from obj in provider.GetTable<LqVuViecToChucEntity>()
                    where obj.IdVuViec == IdVuViec
                    select obj;
					
            LqVuViecToChucEntity ob = (LqVuViecToChucEntity)q.First<LqVuViecToChucEntity>();
            provider.GetTable<LqVuViecToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdToChuc(Guid IdToChuc)
		{
			var q = from obj in provider.GetTable<LqVuViecToChucEntity>()
                    where obj.IdToChuc == IdToChuc
                    select obj;
					
            LqVuViecToChucEntity ob = (LqVuViecToChucEntity)q.First<LqVuViecToChucEntity>();
            provider.GetTable<LqVuViecToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqVuViecToChucEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqVuViecToChucEntity ob = (LqVuViecToChucEntity)q.First<LqVuViecToChucEntity>();
            provider.GetTable<LqVuViecToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaTp(string MaTp)
		{
			var q = from obj in provider.GetTable<LqVuViecToChucEntity>()
                    where obj.MaTp == MaTp
                    select obj;
					
            LqVuViecToChucEntity ob = (LqVuViecToChucEntity)q.First<LqVuViecToChucEntity>();
            provider.GetTable<LqVuViecToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGhiChu(string GhiChu)
		{
			var q = from obj in provider.GetTable<LqVuViecToChucEntity>()
                    where obj.GhiChu == GhiChu
                    select obj;
					
            LqVuViecToChucEntity ob = (LqVuViecToChucEntity)q.First<LqVuViecToChucEntity>();
            provider.GetTable<LqVuViecToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqVuViecToChucEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqVuViecToChucEntity ob = (LqVuViecToChucEntity)q.First<LqVuViecToChucEntity>();
            provider.GetTable<LqVuViecToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqVuViecToChucEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqVuViecToChucEntity ob = (LqVuViecToChucEntity)q.First<LqVuViecToChucEntity>();
            provider.GetTable<LqVuViecToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqVuViecToChucEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqVuViecToChucEntity ob = (LqVuViecToChucEntity)q.First<LqVuViecToChucEntity>();
            provider.GetTable<LqVuViecToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqVuViecToChucEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqVuViecToChucEntity ob = (LqVuViecToChucEntity)q.First<LqVuViecToChucEntity>();
            provider.GetTable<LqVuViecToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqVuViecToChucEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqVuViecToChucEntity ob = (LqVuViecToChucEntity)q.First<LqVuViecToChucEntity>();
            provider.GetTable<LqVuViecToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqVuViecToChucEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqVuViecToChucEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqVuViecToChucEntity>();
		}

		public List<LqVuViecToChucEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqVuViecToChucEntity>()
                        select obj;
            return query.ToList<LqVuViecToChucEntity>();
		}
		
		
		public List<LqVuViecToChucEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqVuViecToChucEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqVuViecToChucEntity>();
		}
		
		
		public List<LqVuViecToChucEntity> SelectByIdVuViec(Guid IdVuViec)
		{
			var query = from obj in provider.GetTable<LqVuViecToChucEntity>()
                        where obj.IdVuViec == IdVuViec
                        select obj;
            return query.ToList<LqVuViecToChucEntity>();
		}
		
		
		public List<LqVuViecToChucEntity> SelectByIdToChuc(Guid IdToChuc)
		{
			var query = from obj in provider.GetTable<LqVuViecToChucEntity>()
                        where obj.IdToChuc == IdToChuc
                        select obj;
            return query.ToList<LqVuViecToChucEntity>();
		}
		
		
		public List<LqVuViecToChucEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqVuViecToChucEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqVuViecToChucEntity>();
		}
		
		
		public List<LqVuViecToChucEntity> SelectByMaTp(string MaTp)
		{
			var query = from obj in provider.GetTable<LqVuViecToChucEntity>()
                        where obj.MaTp == MaTp
                        select obj;
            return query.ToList<LqVuViecToChucEntity>();
		}
		
		
		public List<LqVuViecToChucEntity> SelectByGhiChu(string GhiChu)
		{
			var query = from obj in provider.GetTable<LqVuViecToChucEntity>()
                        where obj.GhiChu == GhiChu
                        select obj;
            return query.ToList<LqVuViecToChucEntity>();
		}
		
		
		public List<LqVuViecToChucEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqVuViecToChucEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqVuViecToChucEntity>();
		}
		
		
		public List<LqVuViecToChucEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqVuViecToChucEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqVuViecToChucEntity>();
		}
		
		
		public List<LqVuViecToChucEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqVuViecToChucEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqVuViecToChucEntity>();
		}
		
		
		public List<LqVuViecToChucEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqVuViecToChucEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqVuViecToChucEntity>();
		}
		
		
		public List<LqVuViecToChucEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqVuViecToChucEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqVuViecToChucEntity>();
		}
		
		
		

	}
}
