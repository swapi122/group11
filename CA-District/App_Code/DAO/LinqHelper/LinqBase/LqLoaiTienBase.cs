




/*
'===============================================================================
'  LinqHelper.DAO.LoaiTienBase
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
	public class LqLoaiTienBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqLoaiTienBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqLoaiTienEntity obj)
		{
			provider.GetTable<LqLoaiTienEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqLoaiTienEntity _obj)
		{
			var q = from obj in provider.GetTable<LqLoaiTienEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqLoaiTienEntity tmp = q.First<LqLoaiTienEntity>();
			
			tmp.TenLoaiTien = _obj.TenLoaiTien;
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
		
		public void Delete(LqLoaiTienEntity obj)
		{
			provider.GetTable<LqLoaiTienEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqLoaiTienEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqLoaiTienEntity ob = (LqLoaiTienEntity)q.First<LqLoaiTienEntity>();
            provider.GetTable<LqLoaiTienEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTenLoaiTien(string TenLoaiTien)
		{
			var q = from obj in provider.GetTable<LqLoaiTienEntity>()
                    where obj.TenLoaiTien == TenLoaiTien
                    select obj;
					
            LqLoaiTienEntity ob = (LqLoaiTienEntity)q.First<LqLoaiTienEntity>();
            provider.GetTable<LqLoaiTienEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqLoaiTienEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqLoaiTienEntity ob = (LqLoaiTienEntity)q.First<LqLoaiTienEntity>();
            provider.GetTable<LqLoaiTienEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGhiChu(string GhiChu)
		{
			var q = from obj in provider.GetTable<LqLoaiTienEntity>()
                    where obj.GhiChu == GhiChu
                    select obj;
					
            LqLoaiTienEntity ob = (LqLoaiTienEntity)q.First<LqLoaiTienEntity>();
            provider.GetTable<LqLoaiTienEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var q = from obj in provider.GetTable<LqLoaiTienEntity>()
                    where obj.LoaiDanhMuc == LoaiDanhMuc
                    select obj;
					
            LqLoaiTienEntity ob = (LqLoaiTienEntity)q.First<LqLoaiTienEntity>();
            provider.GetTable<LqLoaiTienEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqLoaiTienEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqLoaiTienEntity ob = (LqLoaiTienEntity)q.First<LqLoaiTienEntity>();
            provider.GetTable<LqLoaiTienEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqLoaiTienEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqLoaiTienEntity ob = (LqLoaiTienEntity)q.First<LqLoaiTienEntity>();
            provider.GetTable<LqLoaiTienEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqLoaiTienEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqLoaiTienEntity ob = (LqLoaiTienEntity)q.First<LqLoaiTienEntity>();
            provider.GetTable<LqLoaiTienEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqLoaiTienEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqLoaiTienEntity ob = (LqLoaiTienEntity)q.First<LqLoaiTienEntity>();
            provider.GetTable<LqLoaiTienEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			var q = from obj in provider.GetTable<LqLoaiTienEntity>()
                    where obj.NgayHetHan.Value == NgayHetHan
                    select obj;
					
            LqLoaiTienEntity ob = (LqLoaiTienEntity)q.First<LqLoaiTienEntity>();
            provider.GetTable<LqLoaiTienEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqLoaiTienEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqLoaiTienEntity ob = (LqLoaiTienEntity)q.First<LqLoaiTienEntity>();
            provider.GetTable<LqLoaiTienEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqLoaiTienEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqLoaiTienEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqLoaiTienEntity>();
		}

		public List<LqLoaiTienEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqLoaiTienEntity>()
                        select obj;
            return query.ToList<LqLoaiTienEntity>();
		}
		
		
		public List<LqLoaiTienEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqLoaiTienEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqLoaiTienEntity>();
		}
		
		
		public List<LqLoaiTienEntity> SelectByTenLoaiTien(string TenLoaiTien)
		{
			var query = from obj in provider.GetTable<LqLoaiTienEntity>()
                        where obj.TenLoaiTien == TenLoaiTien
                        select obj;
            return query.ToList<LqLoaiTienEntity>();
		}
		
		
		public List<LqLoaiTienEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqLoaiTienEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqLoaiTienEntity>();
		}
		
		
		public List<LqLoaiTienEntity> SelectByGhiChu(string GhiChu)
		{
			var query = from obj in provider.GetTable<LqLoaiTienEntity>()
                        where obj.GhiChu == GhiChu
                        select obj;
            return query.ToList<LqLoaiTienEntity>();
		}
		
		
		public List<LqLoaiTienEntity> SelectByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var query = from obj in provider.GetTable<LqLoaiTienEntity>()
                        where obj.LoaiDanhMuc == LoaiDanhMuc
                        select obj;
            return query.ToList<LqLoaiTienEntity>();
		}
		
		
		public List<LqLoaiTienEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqLoaiTienEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqLoaiTienEntity>();
		}
		
		
		public List<LqLoaiTienEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqLoaiTienEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqLoaiTienEntity>();
		}
		
		
		public List<LqLoaiTienEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqLoaiTienEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqLoaiTienEntity>();
		}
		
		
		public List<LqLoaiTienEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqLoaiTienEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqLoaiTienEntity>();
		}
		
		
		public List<LqLoaiTienEntity> SelectByNgayHetHan(DateTime NgayHetHan)
		{
			var query = from obj in provider.GetTable<LqLoaiTienEntity>()
                        where obj.NgayHetHan.Value == NgayHetHan
                        select obj;
            return query.ToList<LqLoaiTienEntity>();
		}
		
		
		public List<LqLoaiTienEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqLoaiTienEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqLoaiTienEntity>();
		}
		
		
		

	}
}
