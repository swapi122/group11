




/*
'===============================================================================
'  LinqHelper.DAO.PhuongTienGayAnBase
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
	public class LqPhuongTienGayAnBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqPhuongTienGayAnBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqPhuongTienGayAnEntity obj)
		{
			provider.GetTable<LqPhuongTienGayAnEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqPhuongTienGayAnEntity _obj)
		{
			var q = from obj in provider.GetTable<LqPhuongTienGayAnEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqPhuongTienGayAnEntity tmp = q.First<LqPhuongTienGayAnEntity>();
			
			tmp.TenPhuongTienGayAn = _obj.TenPhuongTienGayAn;
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
		
		public void Delete(LqPhuongTienGayAnEntity obj)
		{
			provider.GetTable<LqPhuongTienGayAnEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqPhuongTienGayAnEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqPhuongTienGayAnEntity ob = (LqPhuongTienGayAnEntity)q.First<LqPhuongTienGayAnEntity>();
            provider.GetTable<LqPhuongTienGayAnEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTenPhuongTienGayAn(string TenPhuongTienGayAn)
		{
			var q = from obj in provider.GetTable<LqPhuongTienGayAnEntity>()
                    where obj.TenPhuongTienGayAn == TenPhuongTienGayAn
                    select obj;
					
            LqPhuongTienGayAnEntity ob = (LqPhuongTienGayAnEntity)q.First<LqPhuongTienGayAnEntity>();
            provider.GetTable<LqPhuongTienGayAnEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqPhuongTienGayAnEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqPhuongTienGayAnEntity ob = (LqPhuongTienGayAnEntity)q.First<LqPhuongTienGayAnEntity>();
            provider.GetTable<LqPhuongTienGayAnEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaTp(string MaTp)
		{
			var q = from obj in provider.GetTable<LqPhuongTienGayAnEntity>()
                    where obj.MaTp == MaTp
                    select obj;
					
            LqPhuongTienGayAnEntity ob = (LqPhuongTienGayAnEntity)q.First<LqPhuongTienGayAnEntity>();
            provider.GetTable<LqPhuongTienGayAnEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGhiChu(string GhiChu)
		{
			var q = from obj in provider.GetTable<LqPhuongTienGayAnEntity>()
                    where obj.GhiChu == GhiChu
                    select obj;
					
            LqPhuongTienGayAnEntity ob = (LqPhuongTienGayAnEntity)q.First<LqPhuongTienGayAnEntity>();
            provider.GetTable<LqPhuongTienGayAnEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var q = from obj in provider.GetTable<LqPhuongTienGayAnEntity>()
                    where obj.LoaiDanhMuc == LoaiDanhMuc
                    select obj;
					
            LqPhuongTienGayAnEntity ob = (LqPhuongTienGayAnEntity)q.First<LqPhuongTienGayAnEntity>();
            provider.GetTable<LqPhuongTienGayAnEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqPhuongTienGayAnEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqPhuongTienGayAnEntity ob = (LqPhuongTienGayAnEntity)q.First<LqPhuongTienGayAnEntity>();
            provider.GetTable<LqPhuongTienGayAnEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqPhuongTienGayAnEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqPhuongTienGayAnEntity ob = (LqPhuongTienGayAnEntity)q.First<LqPhuongTienGayAnEntity>();
            provider.GetTable<LqPhuongTienGayAnEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqPhuongTienGayAnEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqPhuongTienGayAnEntity ob = (LqPhuongTienGayAnEntity)q.First<LqPhuongTienGayAnEntity>();
            provider.GetTable<LqPhuongTienGayAnEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqPhuongTienGayAnEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqPhuongTienGayAnEntity ob = (LqPhuongTienGayAnEntity)q.First<LqPhuongTienGayAnEntity>();
            provider.GetTable<LqPhuongTienGayAnEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			var q = from obj in provider.GetTable<LqPhuongTienGayAnEntity>()
                    where obj.NgayHetHan.Value == NgayHetHan
                    select obj;
					
            LqPhuongTienGayAnEntity ob = (LqPhuongTienGayAnEntity)q.First<LqPhuongTienGayAnEntity>();
            provider.GetTable<LqPhuongTienGayAnEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqPhuongTienGayAnEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqPhuongTienGayAnEntity ob = (LqPhuongTienGayAnEntity)q.First<LqPhuongTienGayAnEntity>();
            provider.GetTable<LqPhuongTienGayAnEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqPhuongTienGayAnEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqPhuongTienGayAnEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqPhuongTienGayAnEntity>();
		}

		public List<LqPhuongTienGayAnEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqPhuongTienGayAnEntity>()
                        select obj;
            return query.ToList<LqPhuongTienGayAnEntity>();
		}
		
		
		public List<LqPhuongTienGayAnEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqPhuongTienGayAnEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqPhuongTienGayAnEntity>();
		}
		
		
		public List<LqPhuongTienGayAnEntity> SelectByTenPhuongTienGayAn(string TenPhuongTienGayAn)
		{
			var query = from obj in provider.GetTable<LqPhuongTienGayAnEntity>()
                        where obj.TenPhuongTienGayAn == TenPhuongTienGayAn
                        select obj;
            return query.ToList<LqPhuongTienGayAnEntity>();
		}
		
		
		public List<LqPhuongTienGayAnEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqPhuongTienGayAnEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqPhuongTienGayAnEntity>();
		}
		
		
		public List<LqPhuongTienGayAnEntity> SelectByMaTp(string MaTp)
		{
			var query = from obj in provider.GetTable<LqPhuongTienGayAnEntity>()
                        where obj.MaTp == MaTp
                        select obj;
            return query.ToList<LqPhuongTienGayAnEntity>();
		}
		
		
		public List<LqPhuongTienGayAnEntity> SelectByGhiChu(string GhiChu)
		{
			var query = from obj in provider.GetTable<LqPhuongTienGayAnEntity>()
                        where obj.GhiChu == GhiChu
                        select obj;
            return query.ToList<LqPhuongTienGayAnEntity>();
		}
		
		
		public List<LqPhuongTienGayAnEntity> SelectByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var query = from obj in provider.GetTable<LqPhuongTienGayAnEntity>()
                        where obj.LoaiDanhMuc == LoaiDanhMuc
                        select obj;
            return query.ToList<LqPhuongTienGayAnEntity>();
		}
		
		
		public List<LqPhuongTienGayAnEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqPhuongTienGayAnEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqPhuongTienGayAnEntity>();
		}
		
		
		public List<LqPhuongTienGayAnEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqPhuongTienGayAnEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqPhuongTienGayAnEntity>();
		}
		
		
		public List<LqPhuongTienGayAnEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqPhuongTienGayAnEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqPhuongTienGayAnEntity>();
		}
		
		
		public List<LqPhuongTienGayAnEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqPhuongTienGayAnEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqPhuongTienGayAnEntity>();
		}
		
		
		public List<LqPhuongTienGayAnEntity> SelectByNgayHetHan(DateTime NgayHetHan)
		{
			var query = from obj in provider.GetTable<LqPhuongTienGayAnEntity>()
                        where obj.NgayHetHan.Value == NgayHetHan
                        select obj;
            return query.ToList<LqPhuongTienGayAnEntity>();
		}
		
		
		public List<LqPhuongTienGayAnEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqPhuongTienGayAnEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqPhuongTienGayAnEntity>();
		}
		
		
		

	}
}
