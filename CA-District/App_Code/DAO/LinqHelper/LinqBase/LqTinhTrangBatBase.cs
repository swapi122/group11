




/*
'===============================================================================
'  LinqHelper.DAO.TinhTrangBatBase
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
	public class LqTinhTrangBatBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqTinhTrangBatBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqTinhTrangBatEntity obj)
		{
			provider.GetTable<LqTinhTrangBatEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqTinhTrangBatEntity _obj)
		{
			var q = from obj in provider.GetTable<LqTinhTrangBatEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqTinhTrangBatEntity tmp = q.First<LqTinhTrangBatEntity>();
			
			tmp.TenTinhTrangBat = _obj.TenTinhTrangBat;
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
		
		public void Delete(LqTinhTrangBatEntity obj)
		{
			provider.GetTable<LqTinhTrangBatEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqTinhTrangBatEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqTinhTrangBatEntity ob = (LqTinhTrangBatEntity)q.First<LqTinhTrangBatEntity>();
            provider.GetTable<LqTinhTrangBatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTenTinhTrangBat(string TenTinhTrangBat)
		{
			var q = from obj in provider.GetTable<LqTinhTrangBatEntity>()
                    where obj.TenTinhTrangBat == TenTinhTrangBat
                    select obj;
					
            LqTinhTrangBatEntity ob = (LqTinhTrangBatEntity)q.First<LqTinhTrangBatEntity>();
            provider.GetTable<LqTinhTrangBatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdMaCha(Guid IdMaCha)
		{
			var q = from obj in provider.GetTable<LqTinhTrangBatEntity>()
                    where obj.IdMaCha.Value == IdMaCha
                    select obj;
					
            LqTinhTrangBatEntity ob = (LqTinhTrangBatEntity)q.First<LqTinhTrangBatEntity>();
            provider.GetTable<LqTinhTrangBatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqTinhTrangBatEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqTinhTrangBatEntity ob = (LqTinhTrangBatEntity)q.First<LqTinhTrangBatEntity>();
            provider.GetTable<LqTinhTrangBatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaTp(string MaTp)
		{
			var q = from obj in provider.GetTable<LqTinhTrangBatEntity>()
                    where obj.MaTp == MaTp
                    select obj;
					
            LqTinhTrangBatEntity ob = (LqTinhTrangBatEntity)q.First<LqTinhTrangBatEntity>();
            provider.GetTable<LqTinhTrangBatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGhiChu(string GhiChu)
		{
			var q = from obj in provider.GetTable<LqTinhTrangBatEntity>()
                    where obj.GhiChu == GhiChu
                    select obj;
					
            LqTinhTrangBatEntity ob = (LqTinhTrangBatEntity)q.First<LqTinhTrangBatEntity>();
            provider.GetTable<LqTinhTrangBatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var q = from obj in provider.GetTable<LqTinhTrangBatEntity>()
                    where obj.LoaiDanhMuc == LoaiDanhMuc
                    select obj;
					
            LqTinhTrangBatEntity ob = (LqTinhTrangBatEntity)q.First<LqTinhTrangBatEntity>();
            provider.GetTable<LqTinhTrangBatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqTinhTrangBatEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqTinhTrangBatEntity ob = (LqTinhTrangBatEntity)q.First<LqTinhTrangBatEntity>();
            provider.GetTable<LqTinhTrangBatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqTinhTrangBatEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqTinhTrangBatEntity ob = (LqTinhTrangBatEntity)q.First<LqTinhTrangBatEntity>();
            provider.GetTable<LqTinhTrangBatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqTinhTrangBatEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqTinhTrangBatEntity ob = (LqTinhTrangBatEntity)q.First<LqTinhTrangBatEntity>();
            provider.GetTable<LqTinhTrangBatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqTinhTrangBatEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqTinhTrangBatEntity ob = (LqTinhTrangBatEntity)q.First<LqTinhTrangBatEntity>();
            provider.GetTable<LqTinhTrangBatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			var q = from obj in provider.GetTable<LqTinhTrangBatEntity>()
                    where obj.NgayHetHan.Value == NgayHetHan
                    select obj;
					
            LqTinhTrangBatEntity ob = (LqTinhTrangBatEntity)q.First<LqTinhTrangBatEntity>();
            provider.GetTable<LqTinhTrangBatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqTinhTrangBatEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqTinhTrangBatEntity ob = (LqTinhTrangBatEntity)q.First<LqTinhTrangBatEntity>();
            provider.GetTable<LqTinhTrangBatEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqTinhTrangBatEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqTinhTrangBatEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqTinhTrangBatEntity>();
		}

		public List<LqTinhTrangBatEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqTinhTrangBatEntity>()
                        select obj;
            return query.ToList<LqTinhTrangBatEntity>();
		}
		
		
		public List<LqTinhTrangBatEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqTinhTrangBatEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqTinhTrangBatEntity>();
		}
		
		
		public List<LqTinhTrangBatEntity> SelectByTenTinhTrangBat(string TenTinhTrangBat)
		{
			var query = from obj in provider.GetTable<LqTinhTrangBatEntity>()
                        where obj.TenTinhTrangBat == TenTinhTrangBat
                        select obj;
            return query.ToList<LqTinhTrangBatEntity>();
		}
		
		
		public List<LqTinhTrangBatEntity> SelectByIdMaCha(Guid IdMaCha)
		{
			var query = from obj in provider.GetTable<LqTinhTrangBatEntity>()
                        where obj.IdMaCha.Value == IdMaCha
                        select obj;
            return query.ToList<LqTinhTrangBatEntity>();
		}
		
		
		public List<LqTinhTrangBatEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqTinhTrangBatEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqTinhTrangBatEntity>();
		}
		
		
		public List<LqTinhTrangBatEntity> SelectByMaTp(string MaTp)
		{
			var query = from obj in provider.GetTable<LqTinhTrangBatEntity>()
                        where obj.MaTp == MaTp
                        select obj;
            return query.ToList<LqTinhTrangBatEntity>();
		}
		
		
		public List<LqTinhTrangBatEntity> SelectByGhiChu(string GhiChu)
		{
			var query = from obj in provider.GetTable<LqTinhTrangBatEntity>()
                        where obj.GhiChu == GhiChu
                        select obj;
            return query.ToList<LqTinhTrangBatEntity>();
		}
		
		
		public List<LqTinhTrangBatEntity> SelectByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var query = from obj in provider.GetTable<LqTinhTrangBatEntity>()
                        where obj.LoaiDanhMuc == LoaiDanhMuc
                        select obj;
            return query.ToList<LqTinhTrangBatEntity>();
		}
		
		
		public List<LqTinhTrangBatEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqTinhTrangBatEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqTinhTrangBatEntity>();
		}
		
		
		public List<LqTinhTrangBatEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqTinhTrangBatEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqTinhTrangBatEntity>();
		}
		
		
		public List<LqTinhTrangBatEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqTinhTrangBatEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqTinhTrangBatEntity>();
		}
		
		
		public List<LqTinhTrangBatEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqTinhTrangBatEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqTinhTrangBatEntity>();
		}
		
		
		public List<LqTinhTrangBatEntity> SelectByNgayHetHan(DateTime NgayHetHan)
		{
			var query = from obj in provider.GetTable<LqTinhTrangBatEntity>()
                        where obj.NgayHetHan.Value == NgayHetHan
                        select obj;
            return query.ToList<LqTinhTrangBatEntity>();
		}
		
		
		public List<LqTinhTrangBatEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqTinhTrangBatEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqTinhTrangBatEntity>();
		}
		
		
		

	}
}
