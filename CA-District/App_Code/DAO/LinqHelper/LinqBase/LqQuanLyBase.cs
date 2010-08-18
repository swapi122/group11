




/*
'===============================================================================
'  LinqHelper.DAO.QuanLyBase
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
	public class LqQuanLyBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqQuanLyBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqQuanLyEntity obj)
		{
			provider.GetTable<LqQuanLyEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqQuanLyEntity _obj)
		{
			var q = from obj in provider.GetTable<LqQuanLyEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqQuanLyEntity tmp = q.First<LqQuanLyEntity>();
			
			tmp.TenQuanLy = _obj.TenQuanLy;
			tmp.MaRutGon = _obj.MaRutGon;
			tmp.GhiChu = _obj.GhiChu;
			tmp.LoaiDanhMuc = _obj.LoaiDanhMuc;
			tmp.IdNguoiTao = _obj.IdNguoiTao;
			tmp.NgayTao = _obj.NgayTao;
			tmp.IdNguoiCapNhat = _obj.IdNguoiCapNhat;
			tmp.NgayCapNhat = _obj.NgayCapNhat;
			tmp.NgayHetHan = _obj.NgayHetHan;
			tmp.TrangThai = _obj.TrangThai;
		}
		
		public void Delete(LqQuanLyEntity obj)
		{
			provider.GetTable<LqQuanLyEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqQuanLyEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqQuanLyEntity ob = (LqQuanLyEntity)q.First<LqQuanLyEntity>();
            provider.GetTable<LqQuanLyEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTenQuanLy(string TenQuanLy)
		{
			var q = from obj in provider.GetTable<LqQuanLyEntity>()
                    where obj.TenQuanLy == TenQuanLy
                    select obj;
					
            LqQuanLyEntity ob = (LqQuanLyEntity)q.First<LqQuanLyEntity>();
            provider.GetTable<LqQuanLyEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqQuanLyEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqQuanLyEntity ob = (LqQuanLyEntity)q.First<LqQuanLyEntity>();
            provider.GetTable<LqQuanLyEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGhiChu(string GhiChu)
		{
			var q = from obj in provider.GetTable<LqQuanLyEntity>()
                    where obj.GhiChu == GhiChu
                    select obj;
					
            LqQuanLyEntity ob = (LqQuanLyEntity)q.First<LqQuanLyEntity>();
            provider.GetTable<LqQuanLyEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var q = from obj in provider.GetTable<LqQuanLyEntity>()
                    where obj.LoaiDanhMuc == LoaiDanhMuc
                    select obj;
					
            LqQuanLyEntity ob = (LqQuanLyEntity)q.First<LqQuanLyEntity>();
            provider.GetTable<LqQuanLyEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqQuanLyEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqQuanLyEntity ob = (LqQuanLyEntity)q.First<LqQuanLyEntity>();
            provider.GetTable<LqQuanLyEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqQuanLyEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqQuanLyEntity ob = (LqQuanLyEntity)q.First<LqQuanLyEntity>();
            provider.GetTable<LqQuanLyEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqQuanLyEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqQuanLyEntity ob = (LqQuanLyEntity)q.First<LqQuanLyEntity>();
            provider.GetTable<LqQuanLyEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqQuanLyEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqQuanLyEntity ob = (LqQuanLyEntity)q.First<LqQuanLyEntity>();
            provider.GetTable<LqQuanLyEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			var q = from obj in provider.GetTable<LqQuanLyEntity>()
                    where obj.NgayHetHan.Value == NgayHetHan
                    select obj;
					
            LqQuanLyEntity ob = (LqQuanLyEntity)q.First<LqQuanLyEntity>();
            provider.GetTable<LqQuanLyEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqQuanLyEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqQuanLyEntity ob = (LqQuanLyEntity)q.First<LqQuanLyEntity>();
            provider.GetTable<LqQuanLyEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqQuanLyEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqQuanLyEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqQuanLyEntity>();
		}

		public List<LqQuanLyEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqQuanLyEntity>()
                        select obj;
            return query.ToList<LqQuanLyEntity>();
		}
		
		
		public List<LqQuanLyEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqQuanLyEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqQuanLyEntity>();
		}
		
		
		public List<LqQuanLyEntity> SelectByTenQuanLy(string TenQuanLy)
		{
			var query = from obj in provider.GetTable<LqQuanLyEntity>()
                        where obj.TenQuanLy == TenQuanLy
                        select obj;
            return query.ToList<LqQuanLyEntity>();
		}
		
		
		public List<LqQuanLyEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqQuanLyEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqQuanLyEntity>();
		}
		
		
		public List<LqQuanLyEntity> SelectByGhiChu(string GhiChu)
		{
			var query = from obj in provider.GetTable<LqQuanLyEntity>()
                        where obj.GhiChu == GhiChu
                        select obj;
            return query.ToList<LqQuanLyEntity>();
		}
		
		
		public List<LqQuanLyEntity> SelectByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var query = from obj in provider.GetTable<LqQuanLyEntity>()
                        where obj.LoaiDanhMuc == LoaiDanhMuc
                        select obj;
            return query.ToList<LqQuanLyEntity>();
		}
		
		
		public List<LqQuanLyEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqQuanLyEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqQuanLyEntity>();
		}
		
		
		public List<LqQuanLyEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqQuanLyEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqQuanLyEntity>();
		}
		
		
		public List<LqQuanLyEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqQuanLyEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqQuanLyEntity>();
		}
		
		
		public List<LqQuanLyEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqQuanLyEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqQuanLyEntity>();
		}
		
		
		public List<LqQuanLyEntity> SelectByNgayHetHan(DateTime NgayHetHan)
		{
			var query = from obj in provider.GetTable<LqQuanLyEntity>()
                        where obj.NgayHetHan.Value == NgayHetHan
                        select obj;
            return query.ToList<LqQuanLyEntity>();
		}
		
		
		public List<LqQuanLyEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqQuanLyEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqQuanLyEntity>();
		}
		
		
		

	}
}
