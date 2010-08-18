




/*
'===============================================================================
'  LinqHelper.DAO.ChucNangNhomBase
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
	public class LqChucNangNhomBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqChucNangNhomBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqChucNangNhomEntity obj)
		{
			provider.GetTable<LqChucNangNhomEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqChucNangNhomEntity _obj)
		{
			var q = from obj in provider.GetTable<LqChucNangNhomEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqChucNangNhomEntity tmp = q.First<LqChucNangNhomEntity>();
			
			tmp.IdChucNang = _obj.IdChucNang;
			tmp.IdNhom = _obj.IdNhom;
			tmp.IdNguoiTao = _obj.IdNguoiTao;
			tmp.NgayTao = _obj.NgayTao;
			tmp.IdNguoiCapNhat = _obj.IdNguoiCapNhat;
			tmp.NgayCapNhat = _obj.NgayCapNhat;
			tmp.NgayHetHan = _obj.NgayHetHan;
			tmp.TrangThai = _obj.TrangThai;
		}
		
		public void Delete(LqChucNangNhomEntity obj)
		{
			provider.GetTable<LqChucNangNhomEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqChucNangNhomEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqChucNangNhomEntity ob = (LqChucNangNhomEntity)q.First<LqChucNangNhomEntity>();
            provider.GetTable<LqChucNangNhomEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdChucNang(Guid IdChucNang)
		{
			var q = from obj in provider.GetTable<LqChucNangNhomEntity>()
                    where obj.IdChucNang == IdChucNang
                    select obj;
					
            LqChucNangNhomEntity ob = (LqChucNangNhomEntity)q.First<LqChucNangNhomEntity>();
            provider.GetTable<LqChucNangNhomEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNhom(Guid IdNhom)
		{
			var q = from obj in provider.GetTable<LqChucNangNhomEntity>()
                    where obj.IdNhom == IdNhom
                    select obj;
					
            LqChucNangNhomEntity ob = (LqChucNangNhomEntity)q.First<LqChucNangNhomEntity>();
            provider.GetTable<LqChucNangNhomEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqChucNangNhomEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqChucNangNhomEntity ob = (LqChucNangNhomEntity)q.First<LqChucNangNhomEntity>();
            provider.GetTable<LqChucNangNhomEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqChucNangNhomEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqChucNangNhomEntity ob = (LqChucNangNhomEntity)q.First<LqChucNangNhomEntity>();
            provider.GetTable<LqChucNangNhomEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqChucNangNhomEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqChucNangNhomEntity ob = (LqChucNangNhomEntity)q.First<LqChucNangNhomEntity>();
            provider.GetTable<LqChucNangNhomEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqChucNangNhomEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqChucNangNhomEntity ob = (LqChucNangNhomEntity)q.First<LqChucNangNhomEntity>();
            provider.GetTable<LqChucNangNhomEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			var q = from obj in provider.GetTable<LqChucNangNhomEntity>()
                    where obj.NgayHetHan.Value == NgayHetHan
                    select obj;
					
            LqChucNangNhomEntity ob = (LqChucNangNhomEntity)q.First<LqChucNangNhomEntity>();
            provider.GetTable<LqChucNangNhomEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqChucNangNhomEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqChucNangNhomEntity ob = (LqChucNangNhomEntity)q.First<LqChucNangNhomEntity>();
            provider.GetTable<LqChucNangNhomEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqChucNangNhomEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqChucNangNhomEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqChucNangNhomEntity>();
		}

		public List<LqChucNangNhomEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqChucNangNhomEntity>()
                        select obj;
            return query.ToList<LqChucNangNhomEntity>();
		}
		
		
		public List<LqChucNangNhomEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqChucNangNhomEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqChucNangNhomEntity>();
		}
		
		
		public List<LqChucNangNhomEntity> SelectByIdChucNang(Guid IdChucNang)
		{
			var query = from obj in provider.GetTable<LqChucNangNhomEntity>()
                        where obj.IdChucNang == IdChucNang
                        select obj;
            return query.ToList<LqChucNangNhomEntity>();
		}
		
		
		public List<LqChucNangNhomEntity> SelectByIdNhom(Guid IdNhom)
		{
			var query = from obj in provider.GetTable<LqChucNangNhomEntity>()
                        where obj.IdNhom == IdNhom
                        select obj;
            return query.ToList<LqChucNangNhomEntity>();
		}
		
		
		public List<LqChucNangNhomEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqChucNangNhomEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqChucNangNhomEntity>();
		}
		
		
		public List<LqChucNangNhomEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqChucNangNhomEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqChucNangNhomEntity>();
		}
		
		
		public List<LqChucNangNhomEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqChucNangNhomEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqChucNangNhomEntity>();
		}
		
		
		public List<LqChucNangNhomEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqChucNangNhomEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqChucNangNhomEntity>();
		}
		
		
		public List<LqChucNangNhomEntity> SelectByNgayHetHan(DateTime NgayHetHan)
		{
			var query = from obj in provider.GetTable<LqChucNangNhomEntity>()
                        where obj.NgayHetHan.Value == NgayHetHan
                        select obj;
            return query.ToList<LqChucNangNhomEntity>();
		}
		
		
		public List<LqChucNangNhomEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqChucNangNhomEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqChucNangNhomEntity>();
		}
		
		
		

	}
}
