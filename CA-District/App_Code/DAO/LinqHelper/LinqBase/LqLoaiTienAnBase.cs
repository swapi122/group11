




/*
'===============================================================================
'  LinqHelper.DAO.LoaiTienAnBase
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
	public class LqLoaiTienAnBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqLoaiTienAnBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqLoaiTienAnEntity obj)
		{
			provider.GetTable<LqLoaiTienAnEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqLoaiTienAnEntity _obj)
		{
			var q = from obj in provider.GetTable<LqLoaiTienAnEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqLoaiTienAnEntity tmp = q.First<LqLoaiTienAnEntity>();
			
			tmp.TenLoaiTienAn = _obj.TenLoaiTienAn;
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
		
		public void Delete(LqLoaiTienAnEntity obj)
		{
			provider.GetTable<LqLoaiTienAnEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqLoaiTienAnEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqLoaiTienAnEntity ob = (LqLoaiTienAnEntity)q.First<LqLoaiTienAnEntity>();
            provider.GetTable<LqLoaiTienAnEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTenLoaiTienAn(string TenLoaiTienAn)
		{
			var q = from obj in provider.GetTable<LqLoaiTienAnEntity>()
                    where obj.TenLoaiTienAn == TenLoaiTienAn
                    select obj;
					
            LqLoaiTienAnEntity ob = (LqLoaiTienAnEntity)q.First<LqLoaiTienAnEntity>();
            provider.GetTable<LqLoaiTienAnEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqLoaiTienAnEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqLoaiTienAnEntity ob = (LqLoaiTienAnEntity)q.First<LqLoaiTienAnEntity>();
            provider.GetTable<LqLoaiTienAnEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGhiChu(string GhiChu)
		{
			var q = from obj in provider.GetTable<LqLoaiTienAnEntity>()
                    where obj.GhiChu == GhiChu
                    select obj;
					
            LqLoaiTienAnEntity ob = (LqLoaiTienAnEntity)q.First<LqLoaiTienAnEntity>();
            provider.GetTable<LqLoaiTienAnEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var q = from obj in provider.GetTable<LqLoaiTienAnEntity>()
                    where obj.LoaiDanhMuc == LoaiDanhMuc
                    select obj;
					
            LqLoaiTienAnEntity ob = (LqLoaiTienAnEntity)q.First<LqLoaiTienAnEntity>();
            provider.GetTable<LqLoaiTienAnEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqLoaiTienAnEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqLoaiTienAnEntity ob = (LqLoaiTienAnEntity)q.First<LqLoaiTienAnEntity>();
            provider.GetTable<LqLoaiTienAnEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqLoaiTienAnEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqLoaiTienAnEntity ob = (LqLoaiTienAnEntity)q.First<LqLoaiTienAnEntity>();
            provider.GetTable<LqLoaiTienAnEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqLoaiTienAnEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqLoaiTienAnEntity ob = (LqLoaiTienAnEntity)q.First<LqLoaiTienAnEntity>();
            provider.GetTable<LqLoaiTienAnEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqLoaiTienAnEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqLoaiTienAnEntity ob = (LqLoaiTienAnEntity)q.First<LqLoaiTienAnEntity>();
            provider.GetTable<LqLoaiTienAnEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			var q = from obj in provider.GetTable<LqLoaiTienAnEntity>()
                    where obj.NgayHetHan.Value == NgayHetHan
                    select obj;
					
            LqLoaiTienAnEntity ob = (LqLoaiTienAnEntity)q.First<LqLoaiTienAnEntity>();
            provider.GetTable<LqLoaiTienAnEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqLoaiTienAnEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqLoaiTienAnEntity ob = (LqLoaiTienAnEntity)q.First<LqLoaiTienAnEntity>();
            provider.GetTable<LqLoaiTienAnEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqLoaiTienAnEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqLoaiTienAnEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqLoaiTienAnEntity>();
		}

		public List<LqLoaiTienAnEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqLoaiTienAnEntity>()
                        select obj;
            return query.ToList<LqLoaiTienAnEntity>();
		}
		
		
		public List<LqLoaiTienAnEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqLoaiTienAnEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqLoaiTienAnEntity>();
		}
		
		
		public List<LqLoaiTienAnEntity> SelectByTenLoaiTienAn(string TenLoaiTienAn)
		{
			var query = from obj in provider.GetTable<LqLoaiTienAnEntity>()
                        where obj.TenLoaiTienAn == TenLoaiTienAn
                        select obj;
            return query.ToList<LqLoaiTienAnEntity>();
		}
		
		
		public List<LqLoaiTienAnEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqLoaiTienAnEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqLoaiTienAnEntity>();
		}
		
		
		public List<LqLoaiTienAnEntity> SelectByGhiChu(string GhiChu)
		{
			var query = from obj in provider.GetTable<LqLoaiTienAnEntity>()
                        where obj.GhiChu == GhiChu
                        select obj;
            return query.ToList<LqLoaiTienAnEntity>();
		}
		
		
		public List<LqLoaiTienAnEntity> SelectByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var query = from obj in provider.GetTable<LqLoaiTienAnEntity>()
                        where obj.LoaiDanhMuc == LoaiDanhMuc
                        select obj;
            return query.ToList<LqLoaiTienAnEntity>();
		}
		
		
		public List<LqLoaiTienAnEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqLoaiTienAnEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqLoaiTienAnEntity>();
		}
		
		
		public List<LqLoaiTienAnEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqLoaiTienAnEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqLoaiTienAnEntity>();
		}
		
		
		public List<LqLoaiTienAnEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqLoaiTienAnEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqLoaiTienAnEntity>();
		}
		
		
		public List<LqLoaiTienAnEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqLoaiTienAnEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqLoaiTienAnEntity>();
		}
		
		
		public List<LqLoaiTienAnEntity> SelectByNgayHetHan(DateTime NgayHetHan)
		{
			var query = from obj in provider.GetTable<LqLoaiTienAnEntity>()
                        where obj.NgayHetHan.Value == NgayHetHan
                        select obj;
            return query.ToList<LqLoaiTienAnEntity>();
		}
		
		
		public List<LqLoaiTienAnEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqLoaiTienAnEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqLoaiTienAnEntity>();
		}
		
		
		

	}
}
