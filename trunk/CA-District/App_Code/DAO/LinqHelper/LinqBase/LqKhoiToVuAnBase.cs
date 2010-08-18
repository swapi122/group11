




/*
'===============================================================================
'  LinqHelper.DAO.KhoiToVuAnBase
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
	public class LqKhoiToVuAnBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqKhoiToVuAnBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqKhoiToVuAnEntity obj)
		{
			provider.GetTable<LqKhoiToVuAnEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqKhoiToVuAnEntity _obj)
		{
			var q = from obj in provider.GetTable<LqKhoiToVuAnEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqKhoiToVuAnEntity tmp = q.First<LqKhoiToVuAnEntity>();
			
			tmp.TenKhoiToVuAn = _obj.TenKhoiToVuAn;
			tmp.IdMaCha = _obj.IdMaCha;
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
		
		public void Delete(LqKhoiToVuAnEntity obj)
		{
			provider.GetTable<LqKhoiToVuAnEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqKhoiToVuAnEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqKhoiToVuAnEntity ob = (LqKhoiToVuAnEntity)q.First<LqKhoiToVuAnEntity>();
            provider.GetTable<LqKhoiToVuAnEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTenKhoiToVuAn(string TenKhoiToVuAn)
		{
			var q = from obj in provider.GetTable<LqKhoiToVuAnEntity>()
                    where obj.TenKhoiToVuAn == TenKhoiToVuAn
                    select obj;
					
            LqKhoiToVuAnEntity ob = (LqKhoiToVuAnEntity)q.First<LqKhoiToVuAnEntity>();
            provider.GetTable<LqKhoiToVuAnEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdMaCha(Guid IdMaCha)
		{
			var q = from obj in provider.GetTable<LqKhoiToVuAnEntity>()
                    where obj.IdMaCha.Value == IdMaCha
                    select obj;
					
            LqKhoiToVuAnEntity ob = (LqKhoiToVuAnEntity)q.First<LqKhoiToVuAnEntity>();
            provider.GetTable<LqKhoiToVuAnEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqKhoiToVuAnEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqKhoiToVuAnEntity ob = (LqKhoiToVuAnEntity)q.First<LqKhoiToVuAnEntity>();
            provider.GetTable<LqKhoiToVuAnEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaTp(string MaTp)
		{
			var q = from obj in provider.GetTable<LqKhoiToVuAnEntity>()
                    where obj.MaTp == MaTp
                    select obj;
					
            LqKhoiToVuAnEntity ob = (LqKhoiToVuAnEntity)q.First<LqKhoiToVuAnEntity>();
            provider.GetTable<LqKhoiToVuAnEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGhiChu(string GhiChu)
		{
			var q = from obj in provider.GetTable<LqKhoiToVuAnEntity>()
                    where obj.GhiChu == GhiChu
                    select obj;
					
            LqKhoiToVuAnEntity ob = (LqKhoiToVuAnEntity)q.First<LqKhoiToVuAnEntity>();
            provider.GetTable<LqKhoiToVuAnEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var q = from obj in provider.GetTable<LqKhoiToVuAnEntity>()
                    where obj.LoaiDanhMuc == LoaiDanhMuc
                    select obj;
					
            LqKhoiToVuAnEntity ob = (LqKhoiToVuAnEntity)q.First<LqKhoiToVuAnEntity>();
            provider.GetTable<LqKhoiToVuAnEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqKhoiToVuAnEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqKhoiToVuAnEntity ob = (LqKhoiToVuAnEntity)q.First<LqKhoiToVuAnEntity>();
            provider.GetTable<LqKhoiToVuAnEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqKhoiToVuAnEntity>()
                    where obj.NgayTao.Value == NgayTao
                    select obj;
					
            LqKhoiToVuAnEntity ob = (LqKhoiToVuAnEntity)q.First<LqKhoiToVuAnEntity>();
            provider.GetTable<LqKhoiToVuAnEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqKhoiToVuAnEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqKhoiToVuAnEntity ob = (LqKhoiToVuAnEntity)q.First<LqKhoiToVuAnEntity>();
            provider.GetTable<LqKhoiToVuAnEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqKhoiToVuAnEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqKhoiToVuAnEntity ob = (LqKhoiToVuAnEntity)q.First<LqKhoiToVuAnEntity>();
            provider.GetTable<LqKhoiToVuAnEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			var q = from obj in provider.GetTable<LqKhoiToVuAnEntity>()
                    where obj.NgayHetHan.Value == NgayHetHan
                    select obj;
					
            LqKhoiToVuAnEntity ob = (LqKhoiToVuAnEntity)q.First<LqKhoiToVuAnEntity>();
            provider.GetTable<LqKhoiToVuAnEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqKhoiToVuAnEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqKhoiToVuAnEntity ob = (LqKhoiToVuAnEntity)q.First<LqKhoiToVuAnEntity>();
            provider.GetTable<LqKhoiToVuAnEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqKhoiToVuAnEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqKhoiToVuAnEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqKhoiToVuAnEntity>();
		}

		public List<LqKhoiToVuAnEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqKhoiToVuAnEntity>()
                        select obj;
            return query.ToList<LqKhoiToVuAnEntity>();
		}
		
		
		public List<LqKhoiToVuAnEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqKhoiToVuAnEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqKhoiToVuAnEntity>();
		}
		
		
		public List<LqKhoiToVuAnEntity> SelectByTenKhoiToVuAn(string TenKhoiToVuAn)
		{
			var query = from obj in provider.GetTable<LqKhoiToVuAnEntity>()
                        where obj.TenKhoiToVuAn == TenKhoiToVuAn
                        select obj;
            return query.ToList<LqKhoiToVuAnEntity>();
		}
		
		
		public List<LqKhoiToVuAnEntity> SelectByIdMaCha(Guid IdMaCha)
		{
			var query = from obj in provider.GetTable<LqKhoiToVuAnEntity>()
                        where obj.IdMaCha.Value == IdMaCha
                        select obj;
            return query.ToList<LqKhoiToVuAnEntity>();
		}
		
		
		public List<LqKhoiToVuAnEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqKhoiToVuAnEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqKhoiToVuAnEntity>();
		}
		
		
		public List<LqKhoiToVuAnEntity> SelectByMaTp(string MaTp)
		{
			var query = from obj in provider.GetTable<LqKhoiToVuAnEntity>()
                        where obj.MaTp == MaTp
                        select obj;
            return query.ToList<LqKhoiToVuAnEntity>();
		}
		
		
		public List<LqKhoiToVuAnEntity> SelectByGhiChu(string GhiChu)
		{
			var query = from obj in provider.GetTable<LqKhoiToVuAnEntity>()
                        where obj.GhiChu == GhiChu
                        select obj;
            return query.ToList<LqKhoiToVuAnEntity>();
		}
		
		
		public List<LqKhoiToVuAnEntity> SelectByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var query = from obj in provider.GetTable<LqKhoiToVuAnEntity>()
                        where obj.LoaiDanhMuc == LoaiDanhMuc
                        select obj;
            return query.ToList<LqKhoiToVuAnEntity>();
		}
		
		
		public List<LqKhoiToVuAnEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqKhoiToVuAnEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqKhoiToVuAnEntity>();
		}
		
		
		public List<LqKhoiToVuAnEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqKhoiToVuAnEntity>()
                        where obj.NgayTao.Value == NgayTao
                        select obj;
            return query.ToList<LqKhoiToVuAnEntity>();
		}
		
		
		public List<LqKhoiToVuAnEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqKhoiToVuAnEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqKhoiToVuAnEntity>();
		}
		
		
		public List<LqKhoiToVuAnEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqKhoiToVuAnEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqKhoiToVuAnEntity>();
		}
		
		
		public List<LqKhoiToVuAnEntity> SelectByNgayHetHan(DateTime NgayHetHan)
		{
			var query = from obj in provider.GetTable<LqKhoiToVuAnEntity>()
                        where obj.NgayHetHan.Value == NgayHetHan
                        select obj;
            return query.ToList<LqKhoiToVuAnEntity>();
		}
		
		
		public List<LqKhoiToVuAnEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqKhoiToVuAnEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqKhoiToVuAnEntity>();
		}
		
		
		

	}
}
