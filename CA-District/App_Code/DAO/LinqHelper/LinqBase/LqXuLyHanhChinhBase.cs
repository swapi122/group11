




/*
'===============================================================================
'  LinqHelper.DAO.XuLyHanhChinhBase
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
	public class LqXuLyHanhChinhBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqXuLyHanhChinhBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqXuLyHanhChinhEntity obj)
		{
			provider.GetTable<LqXuLyHanhChinhEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqXuLyHanhChinhEntity _obj)
		{
			var q = from obj in provider.GetTable<LqXuLyHanhChinhEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqXuLyHanhChinhEntity tmp = q.First<LqXuLyHanhChinhEntity>();
			
			tmp.TenXuLyHanhChinh = _obj.TenXuLyHanhChinh;
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
		
		public void Delete(LqXuLyHanhChinhEntity obj)
		{
			provider.GetTable<LqXuLyHanhChinhEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqXuLyHanhChinhEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqXuLyHanhChinhEntity ob = (LqXuLyHanhChinhEntity)q.First<LqXuLyHanhChinhEntity>();
            provider.GetTable<LqXuLyHanhChinhEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTenXuLyHanhChinh(string TenXuLyHanhChinh)
		{
			var q = from obj in provider.GetTable<LqXuLyHanhChinhEntity>()
                    where obj.TenXuLyHanhChinh == TenXuLyHanhChinh
                    select obj;
					
            LqXuLyHanhChinhEntity ob = (LqXuLyHanhChinhEntity)q.First<LqXuLyHanhChinhEntity>();
            provider.GetTable<LqXuLyHanhChinhEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqXuLyHanhChinhEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqXuLyHanhChinhEntity ob = (LqXuLyHanhChinhEntity)q.First<LqXuLyHanhChinhEntity>();
            provider.GetTable<LqXuLyHanhChinhEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGhiChu(string GhiChu)
		{
			var q = from obj in provider.GetTable<LqXuLyHanhChinhEntity>()
                    where obj.GhiChu == GhiChu
                    select obj;
					
            LqXuLyHanhChinhEntity ob = (LqXuLyHanhChinhEntity)q.First<LqXuLyHanhChinhEntity>();
            provider.GetTable<LqXuLyHanhChinhEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var q = from obj in provider.GetTable<LqXuLyHanhChinhEntity>()
                    where obj.LoaiDanhMuc == LoaiDanhMuc
                    select obj;
					
            LqXuLyHanhChinhEntity ob = (LqXuLyHanhChinhEntity)q.First<LqXuLyHanhChinhEntity>();
            provider.GetTable<LqXuLyHanhChinhEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqXuLyHanhChinhEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqXuLyHanhChinhEntity ob = (LqXuLyHanhChinhEntity)q.First<LqXuLyHanhChinhEntity>();
            provider.GetTable<LqXuLyHanhChinhEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqXuLyHanhChinhEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqXuLyHanhChinhEntity ob = (LqXuLyHanhChinhEntity)q.First<LqXuLyHanhChinhEntity>();
            provider.GetTable<LqXuLyHanhChinhEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqXuLyHanhChinhEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqXuLyHanhChinhEntity ob = (LqXuLyHanhChinhEntity)q.First<LqXuLyHanhChinhEntity>();
            provider.GetTable<LqXuLyHanhChinhEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqXuLyHanhChinhEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqXuLyHanhChinhEntity ob = (LqXuLyHanhChinhEntity)q.First<LqXuLyHanhChinhEntity>();
            provider.GetTable<LqXuLyHanhChinhEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			var q = from obj in provider.GetTable<LqXuLyHanhChinhEntity>()
                    where obj.NgayHetHan.Value == NgayHetHan
                    select obj;
					
            LqXuLyHanhChinhEntity ob = (LqXuLyHanhChinhEntity)q.First<LqXuLyHanhChinhEntity>();
            provider.GetTable<LqXuLyHanhChinhEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqXuLyHanhChinhEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqXuLyHanhChinhEntity ob = (LqXuLyHanhChinhEntity)q.First<LqXuLyHanhChinhEntity>();
            provider.GetTable<LqXuLyHanhChinhEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqXuLyHanhChinhEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqXuLyHanhChinhEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqXuLyHanhChinhEntity>();
		}

		public List<LqXuLyHanhChinhEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqXuLyHanhChinhEntity>()
                        select obj;
            return query.ToList<LqXuLyHanhChinhEntity>();
		}
		
		
		public List<LqXuLyHanhChinhEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqXuLyHanhChinhEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqXuLyHanhChinhEntity>();
		}
		
		
		public List<LqXuLyHanhChinhEntity> SelectByTenXuLyHanhChinh(string TenXuLyHanhChinh)
		{
			var query = from obj in provider.GetTable<LqXuLyHanhChinhEntity>()
                        where obj.TenXuLyHanhChinh == TenXuLyHanhChinh
                        select obj;
            return query.ToList<LqXuLyHanhChinhEntity>();
		}
		
		
		public List<LqXuLyHanhChinhEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqXuLyHanhChinhEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqXuLyHanhChinhEntity>();
		}
		
		
		public List<LqXuLyHanhChinhEntity> SelectByGhiChu(string GhiChu)
		{
			var query = from obj in provider.GetTable<LqXuLyHanhChinhEntity>()
                        where obj.GhiChu == GhiChu
                        select obj;
            return query.ToList<LqXuLyHanhChinhEntity>();
		}
		
		
		public List<LqXuLyHanhChinhEntity> SelectByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var query = from obj in provider.GetTable<LqXuLyHanhChinhEntity>()
                        where obj.LoaiDanhMuc == LoaiDanhMuc
                        select obj;
            return query.ToList<LqXuLyHanhChinhEntity>();
		}
		
		
		public List<LqXuLyHanhChinhEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqXuLyHanhChinhEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqXuLyHanhChinhEntity>();
		}
		
		
		public List<LqXuLyHanhChinhEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqXuLyHanhChinhEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqXuLyHanhChinhEntity>();
		}
		
		
		public List<LqXuLyHanhChinhEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqXuLyHanhChinhEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqXuLyHanhChinhEntity>();
		}
		
		
		public List<LqXuLyHanhChinhEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqXuLyHanhChinhEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqXuLyHanhChinhEntity>();
		}
		
		
		public List<LqXuLyHanhChinhEntity> SelectByNgayHetHan(DateTime NgayHetHan)
		{
			var query = from obj in provider.GetTable<LqXuLyHanhChinhEntity>()
                        where obj.NgayHetHan.Value == NgayHetHan
                        select obj;
            return query.ToList<LqXuLyHanhChinhEntity>();
		}
		
		
		public List<LqXuLyHanhChinhEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqXuLyHanhChinhEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqXuLyHanhChinhEntity>();
		}
		
		
		

	}
}
