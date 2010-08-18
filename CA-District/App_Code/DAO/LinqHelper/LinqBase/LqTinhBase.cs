




/*
'===============================================================================
'  LinqHelper.DAO.TinhBase
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
	public class LqTinhBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqTinhBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqTinhEntity obj)
		{
			provider.GetTable<LqTinhEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqTinhEntity _obj)
		{
			var q = from obj in provider.GetTable<LqTinhEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqTinhEntity tmp = q.First<LqTinhEntity>();
			
			tmp.TenTinh = _obj.TenTinh;
			tmp.IdNuoc = _obj.IdNuoc;
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
		
		public void Delete(LqTinhEntity obj)
		{
			provider.GetTable<LqTinhEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqTinhEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqTinhEntity ob = (LqTinhEntity)q.First<LqTinhEntity>();
            provider.GetTable<LqTinhEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTenTinh(string TenTinh)
		{
			var q = from obj in provider.GetTable<LqTinhEntity>()
                    where obj.TenTinh == TenTinh
                    select obj;
					
            LqTinhEntity ob = (LqTinhEntity)q.First<LqTinhEntity>();
            provider.GetTable<LqTinhEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNuoc(Guid IdNuoc)
		{
			var q = from obj in provider.GetTable<LqTinhEntity>()
                    where obj.IdNuoc.Value == IdNuoc
                    select obj;
					
            LqTinhEntity ob = (LqTinhEntity)q.First<LqTinhEntity>();
            provider.GetTable<LqTinhEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqTinhEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqTinhEntity ob = (LqTinhEntity)q.First<LqTinhEntity>();
            provider.GetTable<LqTinhEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaTp(string MaTp)
		{
			var q = from obj in provider.GetTable<LqTinhEntity>()
                    where obj.MaTp == MaTp
                    select obj;
					
            LqTinhEntity ob = (LqTinhEntity)q.First<LqTinhEntity>();
            provider.GetTable<LqTinhEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGhiChu(string GhiChu)
		{
			var q = from obj in provider.GetTable<LqTinhEntity>()
                    where obj.GhiChu == GhiChu
                    select obj;
					
            LqTinhEntity ob = (LqTinhEntity)q.First<LqTinhEntity>();
            provider.GetTable<LqTinhEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var q = from obj in provider.GetTable<LqTinhEntity>()
                    where obj.LoaiDanhMuc == LoaiDanhMuc
                    select obj;
					
            LqTinhEntity ob = (LqTinhEntity)q.First<LqTinhEntity>();
            provider.GetTable<LqTinhEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqTinhEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqTinhEntity ob = (LqTinhEntity)q.First<LqTinhEntity>();
            provider.GetTable<LqTinhEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqTinhEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqTinhEntity ob = (LqTinhEntity)q.First<LqTinhEntity>();
            provider.GetTable<LqTinhEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqTinhEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqTinhEntity ob = (LqTinhEntity)q.First<LqTinhEntity>();
            provider.GetTable<LqTinhEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqTinhEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqTinhEntity ob = (LqTinhEntity)q.First<LqTinhEntity>();
            provider.GetTable<LqTinhEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			var q = from obj in provider.GetTable<LqTinhEntity>()
                    where obj.NgayHetHan.Value == NgayHetHan
                    select obj;
					
            LqTinhEntity ob = (LqTinhEntity)q.First<LqTinhEntity>();
            provider.GetTable<LqTinhEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqTinhEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqTinhEntity ob = (LqTinhEntity)q.First<LqTinhEntity>();
            provider.GetTable<LqTinhEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqTinhEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqTinhEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqTinhEntity>();
		}

		public List<LqTinhEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqTinhEntity>()
                        select obj;
            return query.ToList<LqTinhEntity>();
		}
		
		
		public List<LqTinhEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqTinhEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqTinhEntity>();
		}
		
		
		public List<LqTinhEntity> SelectByTenTinh(string TenTinh)
		{
			var query = from obj in provider.GetTable<LqTinhEntity>()
                        where obj.TenTinh == TenTinh
                        select obj;
            return query.ToList<LqTinhEntity>();
		}
		
		
		public List<LqTinhEntity> SelectByIdNuoc(Guid IdNuoc)
		{
			var query = from obj in provider.GetTable<LqTinhEntity>()
                        where obj.IdNuoc.Value == IdNuoc
                        select obj;
            return query.ToList<LqTinhEntity>();
		}
		
		
		public List<LqTinhEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqTinhEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqTinhEntity>();
		}
		
		
		public List<LqTinhEntity> SelectByMaTp(string MaTp)
		{
			var query = from obj in provider.GetTable<LqTinhEntity>()
                        where obj.MaTp == MaTp
                        select obj;
            return query.ToList<LqTinhEntity>();
		}
		
		
		public List<LqTinhEntity> SelectByGhiChu(string GhiChu)
		{
			var query = from obj in provider.GetTable<LqTinhEntity>()
                        where obj.GhiChu == GhiChu
                        select obj;
            return query.ToList<LqTinhEntity>();
		}
		
		
		public List<LqTinhEntity> SelectByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var query = from obj in provider.GetTable<LqTinhEntity>()
                        where obj.LoaiDanhMuc == LoaiDanhMuc
                        select obj;
            return query.ToList<LqTinhEntity>();
		}
		
		
		public List<LqTinhEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqTinhEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqTinhEntity>();
		}
		
		
		public List<LqTinhEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqTinhEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqTinhEntity>();
		}
		
		
		public List<LqTinhEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqTinhEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqTinhEntity>();
		}
		
		
		public List<LqTinhEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqTinhEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqTinhEntity>();
		}
		
		
		public List<LqTinhEntity> SelectByNgayHetHan(DateTime NgayHetHan)
		{
			var query = from obj in provider.GetTable<LqTinhEntity>()
                        where obj.NgayHetHan.Value == NgayHetHan
                        select obj;
            return query.ToList<LqTinhEntity>();
		}
		
		
		public List<LqTinhEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqTinhEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqTinhEntity>();
		}
		
		
		

	}
}
