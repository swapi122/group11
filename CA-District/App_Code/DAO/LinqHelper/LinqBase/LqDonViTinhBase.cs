




/*
'===============================================================================
'  LinqHelper.DAO.DonViTinhBase
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
	public class LqDonViTinhBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqDonViTinhBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqDonViTinhEntity obj)
		{
			provider.GetTable<LqDonViTinhEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqDonViTinhEntity _obj)
		{
			var q = from obj in provider.GetTable<LqDonViTinhEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqDonViTinhEntity tmp = q.First<LqDonViTinhEntity>();
			
			tmp.TenDonViTinh = _obj.TenDonViTinh;
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
		
		public void Delete(LqDonViTinhEntity obj)
		{
			provider.GetTable<LqDonViTinhEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqDonViTinhEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqDonViTinhEntity ob = (LqDonViTinhEntity)q.First<LqDonViTinhEntity>();
            provider.GetTable<LqDonViTinhEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTenDonViTinh(string TenDonViTinh)
		{
			var q = from obj in provider.GetTable<LqDonViTinhEntity>()
                    where obj.TenDonViTinh == TenDonViTinh
                    select obj;
					
            LqDonViTinhEntity ob = (LqDonViTinhEntity)q.First<LqDonViTinhEntity>();
            provider.GetTable<LqDonViTinhEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqDonViTinhEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqDonViTinhEntity ob = (LqDonViTinhEntity)q.First<LqDonViTinhEntity>();
            provider.GetTable<LqDonViTinhEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaTp(string MaTp)
		{
			var q = from obj in provider.GetTable<LqDonViTinhEntity>()
                    where obj.MaTp == MaTp
                    select obj;
					
            LqDonViTinhEntity ob = (LqDonViTinhEntity)q.First<LqDonViTinhEntity>();
            provider.GetTable<LqDonViTinhEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGhiChu(string GhiChu)
		{
			var q = from obj in provider.GetTable<LqDonViTinhEntity>()
                    where obj.GhiChu == GhiChu
                    select obj;
					
            LqDonViTinhEntity ob = (LqDonViTinhEntity)q.First<LqDonViTinhEntity>();
            provider.GetTable<LqDonViTinhEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var q = from obj in provider.GetTable<LqDonViTinhEntity>()
                    where obj.LoaiDanhMuc == LoaiDanhMuc
                    select obj;
					
            LqDonViTinhEntity ob = (LqDonViTinhEntity)q.First<LqDonViTinhEntity>();
            provider.GetTable<LqDonViTinhEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqDonViTinhEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqDonViTinhEntity ob = (LqDonViTinhEntity)q.First<LqDonViTinhEntity>();
            provider.GetTable<LqDonViTinhEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqDonViTinhEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqDonViTinhEntity ob = (LqDonViTinhEntity)q.First<LqDonViTinhEntity>();
            provider.GetTable<LqDonViTinhEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqDonViTinhEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqDonViTinhEntity ob = (LqDonViTinhEntity)q.First<LqDonViTinhEntity>();
            provider.GetTable<LqDonViTinhEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqDonViTinhEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqDonViTinhEntity ob = (LqDonViTinhEntity)q.First<LqDonViTinhEntity>();
            provider.GetTable<LqDonViTinhEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			var q = from obj in provider.GetTable<LqDonViTinhEntity>()
                    where obj.NgayHetHan.Value == NgayHetHan
                    select obj;
					
            LqDonViTinhEntity ob = (LqDonViTinhEntity)q.First<LqDonViTinhEntity>();
            provider.GetTable<LqDonViTinhEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqDonViTinhEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqDonViTinhEntity ob = (LqDonViTinhEntity)q.First<LqDonViTinhEntity>();
            provider.GetTable<LqDonViTinhEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqDonViTinhEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqDonViTinhEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqDonViTinhEntity>();
		}

		public List<LqDonViTinhEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqDonViTinhEntity>()
                        select obj;
            return query.ToList<LqDonViTinhEntity>();
		}
		
		
		public List<LqDonViTinhEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqDonViTinhEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqDonViTinhEntity>();
		}
		
		
		public List<LqDonViTinhEntity> SelectByTenDonViTinh(string TenDonViTinh)
		{
			var query = from obj in provider.GetTable<LqDonViTinhEntity>()
                        where obj.TenDonViTinh == TenDonViTinh
                        select obj;
            return query.ToList<LqDonViTinhEntity>();
		}
		
		
		public List<LqDonViTinhEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqDonViTinhEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqDonViTinhEntity>();
		}
		
		
		public List<LqDonViTinhEntity> SelectByMaTp(string MaTp)
		{
			var query = from obj in provider.GetTable<LqDonViTinhEntity>()
                        where obj.MaTp == MaTp
                        select obj;
            return query.ToList<LqDonViTinhEntity>();
		}
		
		
		public List<LqDonViTinhEntity> SelectByGhiChu(string GhiChu)
		{
			var query = from obj in provider.GetTable<LqDonViTinhEntity>()
                        where obj.GhiChu == GhiChu
                        select obj;
            return query.ToList<LqDonViTinhEntity>();
		}
		
		
		public List<LqDonViTinhEntity> SelectByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var query = from obj in provider.GetTable<LqDonViTinhEntity>()
                        where obj.LoaiDanhMuc == LoaiDanhMuc
                        select obj;
            return query.ToList<LqDonViTinhEntity>();
		}
		
		
		public List<LqDonViTinhEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqDonViTinhEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqDonViTinhEntity>();
		}
		
		
		public List<LqDonViTinhEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqDonViTinhEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqDonViTinhEntity>();
		}
		
		
		public List<LqDonViTinhEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqDonViTinhEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqDonViTinhEntity>();
		}
		
		
		public List<LqDonViTinhEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqDonViTinhEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqDonViTinhEntity>();
		}
		
		
		public List<LqDonViTinhEntity> SelectByNgayHetHan(DateTime NgayHetHan)
		{
			var query = from obj in provider.GetTable<LqDonViTinhEntity>()
                        where obj.NgayHetHan.Value == NgayHetHan
                        select obj;
            return query.ToList<LqDonViTinhEntity>();
		}
		
		
		public List<LqDonViTinhEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqDonViTinhEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqDonViTinhEntity>();
		}
		
		
		

	}
}
