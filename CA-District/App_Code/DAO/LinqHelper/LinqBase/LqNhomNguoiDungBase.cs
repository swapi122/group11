




/*
'===============================================================================
'  LinqHelper.DAO.NhomNguoiDungBase
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
	public class LqNhomNguoiDungBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqNhomNguoiDungBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqNhomNguoiDungEntity obj)
		{
			provider.GetTable<LqNhomNguoiDungEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqNhomNguoiDungEntity _obj)
		{
			var q = from obj in provider.GetTable<LqNhomNguoiDungEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqNhomNguoiDungEntity tmp = q.First<LqNhomNguoiDungEntity>();
			
			tmp.TenNhomNguoiDung = _obj.TenNhomNguoiDung;
			tmp.MaRutGon = _obj.MaRutGon;
			tmp.MaTp = _obj.MaTp;
			tmp.GhiChu = _obj.GhiChu;
			tmp.LoaiDanhMuc = _obj.LoaiDanhMuc;
			tmp.IdNguoiTao = _obj.IdNguoiTao;
			tmp.NgayTao = _obj.NgayTao;
			tmp.IdNguoiCapNhat = _obj.IdNguoiCapNhat;
			tmp.NgayCapNhat = _obj.NgayCapNhat;
			tmp.NgayHetHan = _obj.NgayHetHan;
			tmp.TrangThai = _obj.TrangThai;
		}
		
		public void Delete(LqNhomNguoiDungEntity obj)
		{
			provider.GetTable<LqNhomNguoiDungEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqNhomNguoiDungEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqNhomNguoiDungEntity ob = (LqNhomNguoiDungEntity)q.First<LqNhomNguoiDungEntity>();
            provider.GetTable<LqNhomNguoiDungEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTenNhomNguoiDung(string TenNhomNguoiDung)
		{
			var q = from obj in provider.GetTable<LqNhomNguoiDungEntity>()
                    where obj.TenNhomNguoiDung == TenNhomNguoiDung
                    select obj;
					
            LqNhomNguoiDungEntity ob = (LqNhomNguoiDungEntity)q.First<LqNhomNguoiDungEntity>();
            provider.GetTable<LqNhomNguoiDungEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqNhomNguoiDungEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqNhomNguoiDungEntity ob = (LqNhomNguoiDungEntity)q.First<LqNhomNguoiDungEntity>();
            provider.GetTable<LqNhomNguoiDungEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaTp(string MaTp)
		{
			var q = from obj in provider.GetTable<LqNhomNguoiDungEntity>()
                    where obj.MaTp == MaTp
                    select obj;
					
            LqNhomNguoiDungEntity ob = (LqNhomNguoiDungEntity)q.First<LqNhomNguoiDungEntity>();
            provider.GetTable<LqNhomNguoiDungEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGhiChu(string GhiChu)
		{
			var q = from obj in provider.GetTable<LqNhomNguoiDungEntity>()
                    where obj.GhiChu == GhiChu
                    select obj;
					
            LqNhomNguoiDungEntity ob = (LqNhomNguoiDungEntity)q.First<LqNhomNguoiDungEntity>();
            provider.GetTable<LqNhomNguoiDungEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var q = from obj in provider.GetTable<LqNhomNguoiDungEntity>()
                    where obj.LoaiDanhMuc == LoaiDanhMuc
                    select obj;
					
            LqNhomNguoiDungEntity ob = (LqNhomNguoiDungEntity)q.First<LqNhomNguoiDungEntity>();
            provider.GetTable<LqNhomNguoiDungEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqNhomNguoiDungEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqNhomNguoiDungEntity ob = (LqNhomNguoiDungEntity)q.First<LqNhomNguoiDungEntity>();
            provider.GetTable<LqNhomNguoiDungEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqNhomNguoiDungEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqNhomNguoiDungEntity ob = (LqNhomNguoiDungEntity)q.First<LqNhomNguoiDungEntity>();
            provider.GetTable<LqNhomNguoiDungEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqNhomNguoiDungEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqNhomNguoiDungEntity ob = (LqNhomNguoiDungEntity)q.First<LqNhomNguoiDungEntity>();
            provider.GetTable<LqNhomNguoiDungEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqNhomNguoiDungEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqNhomNguoiDungEntity ob = (LqNhomNguoiDungEntity)q.First<LqNhomNguoiDungEntity>();
            provider.GetTable<LqNhomNguoiDungEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			var q = from obj in provider.GetTable<LqNhomNguoiDungEntity>()
                    where obj.NgayHetHan.Value == NgayHetHan
                    select obj;
					
            LqNhomNguoiDungEntity ob = (LqNhomNguoiDungEntity)q.First<LqNhomNguoiDungEntity>();
            provider.GetTable<LqNhomNguoiDungEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(string TrangThai)
		{
			var q = from obj in provider.GetTable<LqNhomNguoiDungEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqNhomNguoiDungEntity ob = (LqNhomNguoiDungEntity)q.First<LqNhomNguoiDungEntity>();
            provider.GetTable<LqNhomNguoiDungEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqNhomNguoiDungEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqNhomNguoiDungEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqNhomNguoiDungEntity>();
		}

		public List<LqNhomNguoiDungEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqNhomNguoiDungEntity>()
                        select obj;
            return query.ToList<LqNhomNguoiDungEntity>();
		}
		
		
		public List<LqNhomNguoiDungEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqNhomNguoiDungEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqNhomNguoiDungEntity>();
		}
		
		
		public List<LqNhomNguoiDungEntity> SelectByTenNhomNguoiDung(string TenNhomNguoiDung)
		{
			var query = from obj in provider.GetTable<LqNhomNguoiDungEntity>()
                        where obj.TenNhomNguoiDung == TenNhomNguoiDung
                        select obj;
            return query.ToList<LqNhomNguoiDungEntity>();
		}
		
		
		public List<LqNhomNguoiDungEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqNhomNguoiDungEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqNhomNguoiDungEntity>();
		}
		
		
		public List<LqNhomNguoiDungEntity> SelectByMaTp(string MaTp)
		{
			var query = from obj in provider.GetTable<LqNhomNguoiDungEntity>()
                        where obj.MaTp == MaTp
                        select obj;
            return query.ToList<LqNhomNguoiDungEntity>();
		}
		
		
		public List<LqNhomNguoiDungEntity> SelectByGhiChu(string GhiChu)
		{
			var query = from obj in provider.GetTable<LqNhomNguoiDungEntity>()
                        where obj.GhiChu == GhiChu
                        select obj;
            return query.ToList<LqNhomNguoiDungEntity>();
		}
		
		
		public List<LqNhomNguoiDungEntity> SelectByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var query = from obj in provider.GetTable<LqNhomNguoiDungEntity>()
                        where obj.LoaiDanhMuc == LoaiDanhMuc
                        select obj;
            return query.ToList<LqNhomNguoiDungEntity>();
		}
		
		
		public List<LqNhomNguoiDungEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqNhomNguoiDungEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqNhomNguoiDungEntity>();
		}
		
		
		public List<LqNhomNguoiDungEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqNhomNguoiDungEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqNhomNguoiDungEntity>();
		}
		
		
		public List<LqNhomNguoiDungEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqNhomNguoiDungEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqNhomNguoiDungEntity>();
		}
		
		
		public List<LqNhomNguoiDungEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqNhomNguoiDungEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqNhomNguoiDungEntity>();
		}
		
		
		public List<LqNhomNguoiDungEntity> SelectByNgayHetHan(DateTime NgayHetHan)
		{
			var query = from obj in provider.GetTable<LqNhomNguoiDungEntity>()
                        where obj.NgayHetHan.Value == NgayHetHan
                        select obj;
            return query.ToList<LqNhomNguoiDungEntity>();
		}
		
		
		public List<LqNhomNguoiDungEntity> SelectByTrangThai(string TrangThai)
		{
			var query = from obj in provider.GetTable<LqNhomNguoiDungEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqNhomNguoiDungEntity>();
		}
		
		
		

	}
}
