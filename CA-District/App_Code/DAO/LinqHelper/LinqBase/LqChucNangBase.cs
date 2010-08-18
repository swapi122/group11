


/*
'===============================================================================
'  LinqHelper.DAO.ChucNangBase
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
	public class LqChucNangBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqChucNangBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqChucNangEntity obj)
		{
			provider.GetTable<LqChucNangEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqChucNangEntity _obj)
		{
			var q = from obj in provider.GetTable<LqChucNangEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqChucNangEntity tmp = q.First<LqChucNangEntity>();
			
			tmp.TenChucNang = _obj.TenChucNang;
			tmp.MaRutGon = _obj.MaRutGon;
			tmp.GhiChu = _obj.GhiChu;
			tmp.IdNguoiTao = _obj.IdNguoiTao;
			tmp.NgayTao = _obj.NgayTao;
			tmp.IdNguoiCapNhat = _obj.IdNguoiCapNhat;
			tmp.NgayCapNhat = _obj.NgayCapNhat;
			tmp.NgayHetHan = _obj.NgayHetHan;
			tmp.TrangThai = _obj.TrangThai;
		}
		
		public void Delete(LqChucNangEntity obj)
		{
			provider.GetTable<LqChucNangEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqChucNangEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqChucNangEntity ob = (LqChucNangEntity)q.First<LqChucNangEntity>();
            provider.GetTable<LqChucNangEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTenChucNang(string TenChucNang)
		{
			var q = from obj in provider.GetTable<LqChucNangEntity>()
                    where obj.TenChucNang == TenChucNang
                    select obj;
					
            LqChucNangEntity ob = (LqChucNangEntity)q.First<LqChucNangEntity>();
            provider.GetTable<LqChucNangEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqChucNangEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqChucNangEntity ob = (LqChucNangEntity)q.First<LqChucNangEntity>();
            provider.GetTable<LqChucNangEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGhiChu(string GhiChu)
		{
			var q = from obj in provider.GetTable<LqChucNangEntity>()
                    where obj.GhiChu == GhiChu
                    select obj;
					
            LqChucNangEntity ob = (LqChucNangEntity)q.First<LqChucNangEntity>();
            provider.GetTable<LqChucNangEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqChucNangEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqChucNangEntity ob = (LqChucNangEntity)q.First<LqChucNangEntity>();
            provider.GetTable<LqChucNangEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqChucNangEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqChucNangEntity ob = (LqChucNangEntity)q.First<LqChucNangEntity>();
            provider.GetTable<LqChucNangEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqChucNangEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqChucNangEntity ob = (LqChucNangEntity)q.First<LqChucNangEntity>();
            provider.GetTable<LqChucNangEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqChucNangEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqChucNangEntity ob = (LqChucNangEntity)q.First<LqChucNangEntity>();
            provider.GetTable<LqChucNangEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			var q = from obj in provider.GetTable<LqChucNangEntity>()
                    where obj.NgayHetHan.Value == NgayHetHan
                    select obj;
					
            LqChucNangEntity ob = (LqChucNangEntity)q.First<LqChucNangEntity>();
            provider.GetTable<LqChucNangEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqChucNangEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqChucNangEntity ob = (LqChucNangEntity)q.First<LqChucNangEntity>();
            provider.GetTable<LqChucNangEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqChucNangEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqChucNangEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqChucNangEntity>();
		}

		public List<LqChucNangEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqChucNangEntity>()
                        select obj;
            return query.ToList<LqChucNangEntity>();
		}
		
		
		public List<LqChucNangEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqChucNangEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqChucNangEntity>();
		}
		
		
		public List<LqChucNangEntity> SelectByTenChucNang(string TenChucNang)
		{
			var query = from obj in provider.GetTable<LqChucNangEntity>()
                        where obj.TenChucNang == TenChucNang
                        select obj;
            return query.ToList<LqChucNangEntity>();
		}
		
		
		public List<LqChucNangEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqChucNangEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqChucNangEntity>();
		}
		
		
		public List<LqChucNangEntity> SelectByGhiChu(string GhiChu)
		{
			var query = from obj in provider.GetTable<LqChucNangEntity>()
                        where obj.GhiChu == GhiChu
                        select obj;
            return query.ToList<LqChucNangEntity>();
		}
		
		
		public List<LqChucNangEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqChucNangEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqChucNangEntity>();
		}
		
		
		public List<LqChucNangEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqChucNangEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqChucNangEntity>();
		}
		
		
		public List<LqChucNangEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqChucNangEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqChucNangEntity>();
		}
		
		
		public List<LqChucNangEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqChucNangEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqChucNangEntity>();
		}
		
		
		public List<LqChucNangEntity> SelectByNgayHetHan(DateTime NgayHetHan)
		{
			var query = from obj in provider.GetTable<LqChucNangEntity>()
                        where obj.NgayHetHan.Value == NgayHetHan
                        select obj;
            return query.ToList<LqChucNangEntity>();
		}
		
		
		public List<LqChucNangEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqChucNangEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqChucNangEntity>();
		}
		
		
		

	}
}
