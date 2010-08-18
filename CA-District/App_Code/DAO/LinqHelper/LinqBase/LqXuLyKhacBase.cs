




/*
'===============================================================================
'  LinqHelper.DAO.XuLyKhacBase
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
	public class LqXuLyKhacBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqXuLyKhacBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqXuLyKhacEntity obj)
		{
			provider.GetTable<LqXuLyKhacEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqXuLyKhacEntity _obj)
		{
			var q = from obj in provider.GetTable<LqXuLyKhacEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqXuLyKhacEntity tmp = q.First<LqXuLyKhacEntity>();
			
			tmp.TenXuLyKhac = _obj.TenXuLyKhac;
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
		
		public void Delete(LqXuLyKhacEntity obj)
		{
			provider.GetTable<LqXuLyKhacEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqXuLyKhacEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqXuLyKhacEntity ob = (LqXuLyKhacEntity)q.First<LqXuLyKhacEntity>();
            provider.GetTable<LqXuLyKhacEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTenXuLyKhac(string TenXuLyKhac)
		{
			var q = from obj in provider.GetTable<LqXuLyKhacEntity>()
                    where obj.TenXuLyKhac == TenXuLyKhac
                    select obj;
					
            LqXuLyKhacEntity ob = (LqXuLyKhacEntity)q.First<LqXuLyKhacEntity>();
            provider.GetTable<LqXuLyKhacEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqXuLyKhacEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqXuLyKhacEntity ob = (LqXuLyKhacEntity)q.First<LqXuLyKhacEntity>();
            provider.GetTable<LqXuLyKhacEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGhiChu(string GhiChu)
		{
			var q = from obj in provider.GetTable<LqXuLyKhacEntity>()
                    where obj.GhiChu == GhiChu
                    select obj;
					
            LqXuLyKhacEntity ob = (LqXuLyKhacEntity)q.First<LqXuLyKhacEntity>();
            provider.GetTable<LqXuLyKhacEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var q = from obj in provider.GetTable<LqXuLyKhacEntity>()
                    where obj.LoaiDanhMuc == LoaiDanhMuc
                    select obj;
					
            LqXuLyKhacEntity ob = (LqXuLyKhacEntity)q.First<LqXuLyKhacEntity>();
            provider.GetTable<LqXuLyKhacEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqXuLyKhacEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqXuLyKhacEntity ob = (LqXuLyKhacEntity)q.First<LqXuLyKhacEntity>();
            provider.GetTable<LqXuLyKhacEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqXuLyKhacEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqXuLyKhacEntity ob = (LqXuLyKhacEntity)q.First<LqXuLyKhacEntity>();
            provider.GetTable<LqXuLyKhacEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqXuLyKhacEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqXuLyKhacEntity ob = (LqXuLyKhacEntity)q.First<LqXuLyKhacEntity>();
            provider.GetTable<LqXuLyKhacEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqXuLyKhacEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqXuLyKhacEntity ob = (LqXuLyKhacEntity)q.First<LqXuLyKhacEntity>();
            provider.GetTable<LqXuLyKhacEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			var q = from obj in provider.GetTable<LqXuLyKhacEntity>()
                    where obj.NgayHetHan.Value == NgayHetHan
                    select obj;
					
            LqXuLyKhacEntity ob = (LqXuLyKhacEntity)q.First<LqXuLyKhacEntity>();
            provider.GetTable<LqXuLyKhacEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqXuLyKhacEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqXuLyKhacEntity ob = (LqXuLyKhacEntity)q.First<LqXuLyKhacEntity>();
            provider.GetTable<LqXuLyKhacEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqXuLyKhacEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqXuLyKhacEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqXuLyKhacEntity>();
		}

		public List<LqXuLyKhacEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqXuLyKhacEntity>()
                        select obj;
            return query.ToList<LqXuLyKhacEntity>();
		}
		
		
		public List<LqXuLyKhacEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqXuLyKhacEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqXuLyKhacEntity>();
		}
		
		
		public List<LqXuLyKhacEntity> SelectByTenXuLyKhac(string TenXuLyKhac)
		{
			var query = from obj in provider.GetTable<LqXuLyKhacEntity>()
                        where obj.TenXuLyKhac == TenXuLyKhac
                        select obj;
            return query.ToList<LqXuLyKhacEntity>();
		}
		
		
		public List<LqXuLyKhacEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqXuLyKhacEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqXuLyKhacEntity>();
		}
		
		
		public List<LqXuLyKhacEntity> SelectByGhiChu(string GhiChu)
		{
			var query = from obj in provider.GetTable<LqXuLyKhacEntity>()
                        where obj.GhiChu == GhiChu
                        select obj;
            return query.ToList<LqXuLyKhacEntity>();
		}
		
		
		public List<LqXuLyKhacEntity> SelectByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var query = from obj in provider.GetTable<LqXuLyKhacEntity>()
                        where obj.LoaiDanhMuc == LoaiDanhMuc
                        select obj;
            return query.ToList<LqXuLyKhacEntity>();
		}
		
		
		public List<LqXuLyKhacEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqXuLyKhacEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqXuLyKhacEntity>();
		}
		
		
		public List<LqXuLyKhacEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqXuLyKhacEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqXuLyKhacEntity>();
		}
		
		
		public List<LqXuLyKhacEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqXuLyKhacEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqXuLyKhacEntity>();
		}
		
		
		public List<LqXuLyKhacEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqXuLyKhacEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqXuLyKhacEntity>();
		}
		
		
		public List<LqXuLyKhacEntity> SelectByNgayHetHan(DateTime NgayHetHan)
		{
			var query = from obj in provider.GetTable<LqXuLyKhacEntity>()
                        where obj.NgayHetHan.Value == NgayHetHan
                        select obj;
            return query.ToList<LqXuLyKhacEntity>();
		}
		
		
		public List<LqXuLyKhacEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqXuLyKhacEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqXuLyKhacEntity>();
		}
		
		
		

	}
}
