




/*
'===============================================================================
'  LinqHelper.DAO.HuyenBase
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
	public class LqHuyenBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqHuyenBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqHuyenEntity obj)
		{
			provider.GetTable<LqHuyenEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqHuyenEntity _obj)
		{
			var q = from obj in provider.GetTable<LqHuyenEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqHuyenEntity tmp = q.First<LqHuyenEntity>();
			
			tmp.TenHuyen = _obj.TenHuyen;
			tmp.IdTinh = _obj.IdTinh;
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
		
		public void Delete(LqHuyenEntity obj)
		{
			provider.GetTable<LqHuyenEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqHuyenEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqHuyenEntity ob = (LqHuyenEntity)q.First<LqHuyenEntity>();
            provider.GetTable<LqHuyenEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTenHuyen(string TenHuyen)
		{
			var q = from obj in provider.GetTable<LqHuyenEntity>()
                    where obj.TenHuyen == TenHuyen
                    select obj;
					
            LqHuyenEntity ob = (LqHuyenEntity)q.First<LqHuyenEntity>();
            provider.GetTable<LqHuyenEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdTinh(Guid IdTinh)
		{
			var q = from obj in provider.GetTable<LqHuyenEntity>()
                    where obj.IdTinh.Value == IdTinh
                    select obj;
					
            LqHuyenEntity ob = (LqHuyenEntity)q.First<LqHuyenEntity>();
            provider.GetTable<LqHuyenEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqHuyenEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqHuyenEntity ob = (LqHuyenEntity)q.First<LqHuyenEntity>();
            provider.GetTable<LqHuyenEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaTp(string MaTp)
		{
			var q = from obj in provider.GetTable<LqHuyenEntity>()
                    where obj.MaTp == MaTp
                    select obj;
					
            LqHuyenEntity ob = (LqHuyenEntity)q.First<LqHuyenEntity>();
            provider.GetTable<LqHuyenEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGhiChu(string GhiChu)
		{
			var q = from obj in provider.GetTable<LqHuyenEntity>()
                    where obj.GhiChu == GhiChu
                    select obj;
					
            LqHuyenEntity ob = (LqHuyenEntity)q.First<LqHuyenEntity>();
            provider.GetTable<LqHuyenEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var q = from obj in provider.GetTable<LqHuyenEntity>()
                    where obj.LoaiDanhMuc == LoaiDanhMuc
                    select obj;
					
            LqHuyenEntity ob = (LqHuyenEntity)q.First<LqHuyenEntity>();
            provider.GetTable<LqHuyenEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqHuyenEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqHuyenEntity ob = (LqHuyenEntity)q.First<LqHuyenEntity>();
            provider.GetTable<LqHuyenEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqHuyenEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqHuyenEntity ob = (LqHuyenEntity)q.First<LqHuyenEntity>();
            provider.GetTable<LqHuyenEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqHuyenEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqHuyenEntity ob = (LqHuyenEntity)q.First<LqHuyenEntity>();
            provider.GetTable<LqHuyenEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqHuyenEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqHuyenEntity ob = (LqHuyenEntity)q.First<LqHuyenEntity>();
            provider.GetTable<LqHuyenEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			var q = from obj in provider.GetTable<LqHuyenEntity>()
                    where obj.NgayHetHan.Value == NgayHetHan
                    select obj;
					
            LqHuyenEntity ob = (LqHuyenEntity)q.First<LqHuyenEntity>();
            provider.GetTable<LqHuyenEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqHuyenEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqHuyenEntity ob = (LqHuyenEntity)q.First<LqHuyenEntity>();
            provider.GetTable<LqHuyenEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqHuyenEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqHuyenEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqHuyenEntity>();
		}

		public List<LqHuyenEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqHuyenEntity>()
                        select obj;
            return query.ToList<LqHuyenEntity>();
		}
		
		
		public List<LqHuyenEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqHuyenEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqHuyenEntity>();
		}
		
		
		public List<LqHuyenEntity> SelectByTenHuyen(string TenHuyen)
		{
			var query = from obj in provider.GetTable<LqHuyenEntity>()
                        where obj.TenHuyen == TenHuyen
                        select obj;
            return query.ToList<LqHuyenEntity>();
		}
		
		
		public List<LqHuyenEntity> SelectByIdTinh(Guid IdTinh)
		{
			var query = from obj in provider.GetTable<LqHuyenEntity>()
                        where obj.IdTinh.Value == IdTinh
                        select obj;
            return query.ToList<LqHuyenEntity>();
		}
		
		
		public List<LqHuyenEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqHuyenEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqHuyenEntity>();
		}
		
		
		public List<LqHuyenEntity> SelectByMaTp(string MaTp)
		{
			var query = from obj in provider.GetTable<LqHuyenEntity>()
                        where obj.MaTp == MaTp
                        select obj;
            return query.ToList<LqHuyenEntity>();
		}
		
		
		public List<LqHuyenEntity> SelectByGhiChu(string GhiChu)
		{
			var query = from obj in provider.GetTable<LqHuyenEntity>()
                        where obj.GhiChu == GhiChu
                        select obj;
            return query.ToList<LqHuyenEntity>();
		}
		
		
		public List<LqHuyenEntity> SelectByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var query = from obj in provider.GetTable<LqHuyenEntity>()
                        where obj.LoaiDanhMuc == LoaiDanhMuc
                        select obj;
            return query.ToList<LqHuyenEntity>();
		}
		
		
		public List<LqHuyenEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqHuyenEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqHuyenEntity>();
		}
		
		
		public List<LqHuyenEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqHuyenEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqHuyenEntity>();
		}
		
		
		public List<LqHuyenEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqHuyenEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqHuyenEntity>();
		}
		
		
		public List<LqHuyenEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqHuyenEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqHuyenEntity>();
		}
		
		
		public List<LqHuyenEntity> SelectByNgayHetHan(DateTime NgayHetHan)
		{
			var query = from obj in provider.GetTable<LqHuyenEntity>()
                        where obj.NgayHetHan.Value == NgayHetHan
                        select obj;
            return query.ToList<LqHuyenEntity>();
		}
		
		
		public List<LqHuyenEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqHuyenEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqHuyenEntity>();
		}
		
		
		

	}
}
