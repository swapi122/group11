




/*
'===============================================================================
'  LinqHelper.DAO.HinhThucXuLyBase
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
	public class LqHinhThucXuLyBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqHinhThucXuLyBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqHinhThucXuLyEntity obj)
		{
			provider.GetTable<LqHinhThucXuLyEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqHinhThucXuLyEntity _obj)
		{
			var q = from obj in provider.GetTable<LqHinhThucXuLyEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqHinhThucXuLyEntity tmp = q.First<LqHinhThucXuLyEntity>();
			
			tmp.TenHinhThucXuLy = _obj.TenHinhThucXuLy;
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
		
		public void Delete(LqHinhThucXuLyEntity obj)
		{
			provider.GetTable<LqHinhThucXuLyEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqHinhThucXuLyEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqHinhThucXuLyEntity ob = (LqHinhThucXuLyEntity)q.First<LqHinhThucXuLyEntity>();
            provider.GetTable<LqHinhThucXuLyEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTenHinhThucXuLy(string TenHinhThucXuLy)
		{
			var q = from obj in provider.GetTable<LqHinhThucXuLyEntity>()
                    where obj.TenHinhThucXuLy == TenHinhThucXuLy
                    select obj;
					
            LqHinhThucXuLyEntity ob = (LqHinhThucXuLyEntity)q.First<LqHinhThucXuLyEntity>();
            provider.GetTable<LqHinhThucXuLyEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqHinhThucXuLyEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqHinhThucXuLyEntity ob = (LqHinhThucXuLyEntity)q.First<LqHinhThucXuLyEntity>();
            provider.GetTable<LqHinhThucXuLyEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaTp(string MaTp)
		{
			var q = from obj in provider.GetTable<LqHinhThucXuLyEntity>()
                    where obj.MaTp == MaTp
                    select obj;
					
            LqHinhThucXuLyEntity ob = (LqHinhThucXuLyEntity)q.First<LqHinhThucXuLyEntity>();
            provider.GetTable<LqHinhThucXuLyEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGhiChu(string GhiChu)
		{
			var q = from obj in provider.GetTable<LqHinhThucXuLyEntity>()
                    where obj.GhiChu == GhiChu
                    select obj;
					
            LqHinhThucXuLyEntity ob = (LqHinhThucXuLyEntity)q.First<LqHinhThucXuLyEntity>();
            provider.GetTable<LqHinhThucXuLyEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var q = from obj in provider.GetTable<LqHinhThucXuLyEntity>()
                    where obj.LoaiDanhMuc == LoaiDanhMuc
                    select obj;
					
            LqHinhThucXuLyEntity ob = (LqHinhThucXuLyEntity)q.First<LqHinhThucXuLyEntity>();
            provider.GetTable<LqHinhThucXuLyEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqHinhThucXuLyEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqHinhThucXuLyEntity ob = (LqHinhThucXuLyEntity)q.First<LqHinhThucXuLyEntity>();
            provider.GetTable<LqHinhThucXuLyEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqHinhThucXuLyEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqHinhThucXuLyEntity ob = (LqHinhThucXuLyEntity)q.First<LqHinhThucXuLyEntity>();
            provider.GetTable<LqHinhThucXuLyEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqHinhThucXuLyEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqHinhThucXuLyEntity ob = (LqHinhThucXuLyEntity)q.First<LqHinhThucXuLyEntity>();
            provider.GetTable<LqHinhThucXuLyEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqHinhThucXuLyEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqHinhThucXuLyEntity ob = (LqHinhThucXuLyEntity)q.First<LqHinhThucXuLyEntity>();
            provider.GetTable<LqHinhThucXuLyEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			var q = from obj in provider.GetTable<LqHinhThucXuLyEntity>()
                    where obj.NgayHetHan.Value == NgayHetHan
                    select obj;
					
            LqHinhThucXuLyEntity ob = (LqHinhThucXuLyEntity)q.First<LqHinhThucXuLyEntity>();
            provider.GetTable<LqHinhThucXuLyEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqHinhThucXuLyEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqHinhThucXuLyEntity ob = (LqHinhThucXuLyEntity)q.First<LqHinhThucXuLyEntity>();
            provider.GetTable<LqHinhThucXuLyEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqHinhThucXuLyEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqHinhThucXuLyEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqHinhThucXuLyEntity>();
		}

		public List<LqHinhThucXuLyEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqHinhThucXuLyEntity>()
                        select obj;
            return query.ToList<LqHinhThucXuLyEntity>();
		}
		
		
		public List<LqHinhThucXuLyEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqHinhThucXuLyEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqHinhThucXuLyEntity>();
		}
		
		
		public List<LqHinhThucXuLyEntity> SelectByTenHinhThucXuLy(string TenHinhThucXuLy)
		{
			var query = from obj in provider.GetTable<LqHinhThucXuLyEntity>()
                        where obj.TenHinhThucXuLy == TenHinhThucXuLy
                        select obj;
            return query.ToList<LqHinhThucXuLyEntity>();
		}
		
		
		public List<LqHinhThucXuLyEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqHinhThucXuLyEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqHinhThucXuLyEntity>();
		}
		
		
		public List<LqHinhThucXuLyEntity> SelectByMaTp(string MaTp)
		{
			var query = from obj in provider.GetTable<LqHinhThucXuLyEntity>()
                        where obj.MaTp == MaTp
                        select obj;
            return query.ToList<LqHinhThucXuLyEntity>();
		}
		
		
		public List<LqHinhThucXuLyEntity> SelectByGhiChu(string GhiChu)
		{
			var query = from obj in provider.GetTable<LqHinhThucXuLyEntity>()
                        where obj.GhiChu == GhiChu
                        select obj;
            return query.ToList<LqHinhThucXuLyEntity>();
		}
		
		
		public List<LqHinhThucXuLyEntity> SelectByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var query = from obj in provider.GetTable<LqHinhThucXuLyEntity>()
                        where obj.LoaiDanhMuc == LoaiDanhMuc
                        select obj;
            return query.ToList<LqHinhThucXuLyEntity>();
		}
		
		
		public List<LqHinhThucXuLyEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqHinhThucXuLyEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqHinhThucXuLyEntity>();
		}
		
		
		public List<LqHinhThucXuLyEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqHinhThucXuLyEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqHinhThucXuLyEntity>();
		}
		
		
		public List<LqHinhThucXuLyEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqHinhThucXuLyEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqHinhThucXuLyEntity>();
		}
		
		
		public List<LqHinhThucXuLyEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqHinhThucXuLyEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqHinhThucXuLyEntity>();
		}
		
		
		public List<LqHinhThucXuLyEntity> SelectByNgayHetHan(DateTime NgayHetHan)
		{
			var query = from obj in provider.GetTable<LqHinhThucXuLyEntity>()
                        where obj.NgayHetHan.Value == NgayHetHan
                        select obj;
            return query.ToList<LqHinhThucXuLyEntity>();
		}
		
		
		public List<LqHinhThucXuLyEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqHinhThucXuLyEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqHinhThucXuLyEntity>();
		}
		
		
		

	}
}
