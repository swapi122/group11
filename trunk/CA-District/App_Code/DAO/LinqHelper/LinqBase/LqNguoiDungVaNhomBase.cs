




/*
'===============================================================================
'  LinqHelper.DAO.NguoiDungVaNhomBase
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
	public class LqNguoiDungVaNhomBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqNguoiDungVaNhomBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqNguoiDungVaNhomEntity obj)
		{
			provider.GetTable<LqNguoiDungVaNhomEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqNguoiDungVaNhomEntity _obj)
		{
			var q = from obj in provider.GetTable<LqNguoiDungVaNhomEntity>()
                    where obj.IdNguoiDungVaNhom == _obj.IdNguoiDungVaNhom
                    select obj;
			LqNguoiDungVaNhomEntity tmp = q.First<LqNguoiDungVaNhomEntity>();
			
			tmp.IdNguoiDung = _obj.IdNguoiDung;
			tmp.IdNhom = _obj.IdNhom;
			tmp.MaTp = _obj.MaTp;
			tmp.IdNguoiTao = _obj.IdNguoiTao;
			tmp.NgayTao = _obj.NgayTao;
			tmp.IdNguoiCapNhat = _obj.IdNguoiCapNhat;
			tmp.NgayCapNhat = _obj.NgayCapNhat;
			tmp.TrangThai = _obj.TrangThai;
		}
		
		public void Delete(LqNguoiDungVaNhomEntity obj)
		{
			provider.GetTable<LqNguoiDungVaNhomEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiDungVaNhom(Guid IdNguoiDungVaNhom)
		{
			var q = from obj in provider.GetTable<LqNguoiDungVaNhomEntity>()
                    where obj.IdNguoiDungVaNhom == IdNguoiDungVaNhom
                    select obj;
					
            LqNguoiDungVaNhomEntity ob = (LqNguoiDungVaNhomEntity)q.First<LqNguoiDungVaNhomEntity>();
            provider.GetTable<LqNguoiDungVaNhomEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiDung(Guid IdNguoiDung)
		{
			var q = from obj in provider.GetTable<LqNguoiDungVaNhomEntity>()
                    where obj.IdNguoiDung == IdNguoiDung
                    select obj;
					
            LqNguoiDungVaNhomEntity ob = (LqNguoiDungVaNhomEntity)q.First<LqNguoiDungVaNhomEntity>();
            provider.GetTable<LqNguoiDungVaNhomEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNhom(Guid IdNhom)
		{
			var q = from obj in provider.GetTable<LqNguoiDungVaNhomEntity>()
                    where obj.IdNhom == IdNhom
                    select obj;
					
            LqNguoiDungVaNhomEntity ob = (LqNguoiDungVaNhomEntity)q.First<LqNguoiDungVaNhomEntity>();
            provider.GetTable<LqNguoiDungVaNhomEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaTp(string MaTp)
		{
			var q = from obj in provider.GetTable<LqNguoiDungVaNhomEntity>()
                    where obj.MaTp == MaTp
                    select obj;
					
            LqNguoiDungVaNhomEntity ob = (LqNguoiDungVaNhomEntity)q.First<LqNguoiDungVaNhomEntity>();
            provider.GetTable<LqNguoiDungVaNhomEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqNguoiDungVaNhomEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqNguoiDungVaNhomEntity ob = (LqNguoiDungVaNhomEntity)q.First<LqNguoiDungVaNhomEntity>();
            provider.GetTable<LqNguoiDungVaNhomEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqNguoiDungVaNhomEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqNguoiDungVaNhomEntity ob = (LqNguoiDungVaNhomEntity)q.First<LqNguoiDungVaNhomEntity>();
            provider.GetTable<LqNguoiDungVaNhomEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqNguoiDungVaNhomEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqNguoiDungVaNhomEntity ob = (LqNguoiDungVaNhomEntity)q.First<LqNguoiDungVaNhomEntity>();
            provider.GetTable<LqNguoiDungVaNhomEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqNguoiDungVaNhomEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqNguoiDungVaNhomEntity ob = (LqNguoiDungVaNhomEntity)q.First<LqNguoiDungVaNhomEntity>();
            provider.GetTable<LqNguoiDungVaNhomEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqNguoiDungVaNhomEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqNguoiDungVaNhomEntity ob = (LqNguoiDungVaNhomEntity)q.First<LqNguoiDungVaNhomEntity>();
            provider.GetTable<LqNguoiDungVaNhomEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqNguoiDungVaNhomEntity SelectOne(Guid IdNguoiDungVaNhom)
		{
			var query = from obj in provider.GetTable<LqNguoiDungVaNhomEntity>()
                        where obj.IdNguoiDungVaNhom == IdNguoiDungVaNhom
                        select obj;
            return query.First<LqNguoiDungVaNhomEntity>();
		}

		public List<LqNguoiDungVaNhomEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqNguoiDungVaNhomEntity>()
                        select obj;
            return query.ToList<LqNguoiDungVaNhomEntity>();
		}
		
		
		public List<LqNguoiDungVaNhomEntity> SelectByIdNguoiDungVaNhom(Guid IdNguoiDungVaNhom)
		{
			var query = from obj in provider.GetTable<LqNguoiDungVaNhomEntity>()
                        where obj.IdNguoiDungVaNhom == IdNguoiDungVaNhom
                        select obj;
            return query.ToList<LqNguoiDungVaNhomEntity>();
		}
		
		
		public List<LqNguoiDungVaNhomEntity> SelectByIdNguoiDung(Guid IdNguoiDung)
		{
			var query = from obj in provider.GetTable<LqNguoiDungVaNhomEntity>()
                        where obj.IdNguoiDung == IdNguoiDung
                        select obj;
            return query.ToList<LqNguoiDungVaNhomEntity>();
		}
		
		
		public List<LqNguoiDungVaNhomEntity> SelectByIdNhom(Guid IdNhom)
		{
			var query = from obj in provider.GetTable<LqNguoiDungVaNhomEntity>()
                        where obj.IdNhom == IdNhom
                        select obj;
            return query.ToList<LqNguoiDungVaNhomEntity>();
		}
		
		
		public List<LqNguoiDungVaNhomEntity> SelectByMaTp(string MaTp)
		{
			var query = from obj in provider.GetTable<LqNguoiDungVaNhomEntity>()
                        where obj.MaTp == MaTp
                        select obj;
            return query.ToList<LqNguoiDungVaNhomEntity>();
		}
		
		
		public List<LqNguoiDungVaNhomEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqNguoiDungVaNhomEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqNguoiDungVaNhomEntity>();
		}
		
		
		public List<LqNguoiDungVaNhomEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqNguoiDungVaNhomEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqNguoiDungVaNhomEntity>();
		}
		
		
		public List<LqNguoiDungVaNhomEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqNguoiDungVaNhomEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqNguoiDungVaNhomEntity>();
		}
		
		
		public List<LqNguoiDungVaNhomEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqNguoiDungVaNhomEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqNguoiDungVaNhomEntity>();
		}
		
		
		public List<LqNguoiDungVaNhomEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqNguoiDungVaNhomEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqNguoiDungVaNhomEntity>();
		}
		
		
		

	}
}
