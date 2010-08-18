




/*
'===============================================================================
'  LinqHelper.DAO.KiemDienBase
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
	public class LqKiemDienBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqKiemDienBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqKiemDienEntity obj)
		{
			provider.GetTable<LqKiemDienEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqKiemDienEntity _obj)
		{
			var q = from obj in provider.GetTable<LqKiemDienEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqKiemDienEntity tmp = q.First<LqKiemDienEntity>();
			
			tmp.TenKiemDien = _obj.TenKiemDien;
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
		
		public void Delete(LqKiemDienEntity obj)
		{
			provider.GetTable<LqKiemDienEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqKiemDienEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqKiemDienEntity ob = (LqKiemDienEntity)q.First<LqKiemDienEntity>();
            provider.GetTable<LqKiemDienEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTenKiemDien(string TenKiemDien)
		{
			var q = from obj in provider.GetTable<LqKiemDienEntity>()
                    where obj.TenKiemDien == TenKiemDien
                    select obj;
					
            LqKiemDienEntity ob = (LqKiemDienEntity)q.First<LqKiemDienEntity>();
            provider.GetTable<LqKiemDienEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqKiemDienEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqKiemDienEntity ob = (LqKiemDienEntity)q.First<LqKiemDienEntity>();
            provider.GetTable<LqKiemDienEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGhiChu(string GhiChu)
		{
			var q = from obj in provider.GetTable<LqKiemDienEntity>()
                    where obj.GhiChu == GhiChu
                    select obj;
					
            LqKiemDienEntity ob = (LqKiemDienEntity)q.First<LqKiemDienEntity>();
            provider.GetTable<LqKiemDienEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var q = from obj in provider.GetTable<LqKiemDienEntity>()
                    where obj.LoaiDanhMuc == LoaiDanhMuc
                    select obj;
					
            LqKiemDienEntity ob = (LqKiemDienEntity)q.First<LqKiemDienEntity>();
            provider.GetTable<LqKiemDienEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqKiemDienEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqKiemDienEntity ob = (LqKiemDienEntity)q.First<LqKiemDienEntity>();
            provider.GetTable<LqKiemDienEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqKiemDienEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqKiemDienEntity ob = (LqKiemDienEntity)q.First<LqKiemDienEntity>();
            provider.GetTable<LqKiemDienEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqKiemDienEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqKiemDienEntity ob = (LqKiemDienEntity)q.First<LqKiemDienEntity>();
            provider.GetTable<LqKiemDienEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqKiemDienEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqKiemDienEntity ob = (LqKiemDienEntity)q.First<LqKiemDienEntity>();
            provider.GetTable<LqKiemDienEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			var q = from obj in provider.GetTable<LqKiemDienEntity>()
                    where obj.NgayHetHan.Value == NgayHetHan
                    select obj;
					
            LqKiemDienEntity ob = (LqKiemDienEntity)q.First<LqKiemDienEntity>();
            provider.GetTable<LqKiemDienEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqKiemDienEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqKiemDienEntity ob = (LqKiemDienEntity)q.First<LqKiemDienEntity>();
            provider.GetTable<LqKiemDienEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqKiemDienEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqKiemDienEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqKiemDienEntity>();
		}

		public List<LqKiemDienEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqKiemDienEntity>()
                        select obj;
            return query.ToList<LqKiemDienEntity>();
		}
		
		
		public List<LqKiemDienEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqKiemDienEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqKiemDienEntity>();
		}
		
		
		public List<LqKiemDienEntity> SelectByTenKiemDien(string TenKiemDien)
		{
			var query = from obj in provider.GetTable<LqKiemDienEntity>()
                        where obj.TenKiemDien == TenKiemDien
                        select obj;
            return query.ToList<LqKiemDienEntity>();
		}
		
		
		public List<LqKiemDienEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqKiemDienEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqKiemDienEntity>();
		}
		
		
		public List<LqKiemDienEntity> SelectByGhiChu(string GhiChu)
		{
			var query = from obj in provider.GetTable<LqKiemDienEntity>()
                        where obj.GhiChu == GhiChu
                        select obj;
            return query.ToList<LqKiemDienEntity>();
		}
		
		
		public List<LqKiemDienEntity> SelectByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var query = from obj in provider.GetTable<LqKiemDienEntity>()
                        where obj.LoaiDanhMuc == LoaiDanhMuc
                        select obj;
            return query.ToList<LqKiemDienEntity>();
		}
		
		
		public List<LqKiemDienEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqKiemDienEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqKiemDienEntity>();
		}
		
		
		public List<LqKiemDienEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqKiemDienEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqKiemDienEntity>();
		}
		
		
		public List<LqKiemDienEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqKiemDienEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqKiemDienEntity>();
		}
		
		
		public List<LqKiemDienEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqKiemDienEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqKiemDienEntity>();
		}
		
		
		public List<LqKiemDienEntity> SelectByNgayHetHan(DateTime NgayHetHan)
		{
			var query = from obj in provider.GetTable<LqKiemDienEntity>()
                        where obj.NgayHetHan.Value == NgayHetHan
                        select obj;
            return query.ToList<LqKiemDienEntity>();
		}
		
		
		public List<LqKiemDienEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqKiemDienEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqKiemDienEntity>();
		}
		
		
		

	}
}
