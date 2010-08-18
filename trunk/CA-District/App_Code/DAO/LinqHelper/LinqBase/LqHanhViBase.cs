




/*
'===============================================================================
'  LinqHelper.DAO.HanhViBase
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
	public class LqHanhViBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqHanhViBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqHanhViEntity obj)
		{
			provider.GetTable<LqHanhViEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqHanhViEntity _obj)
		{
			var q = from obj in provider.GetTable<LqHanhViEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqHanhViEntity tmp = q.First<LqHanhViEntity>();
			
			tmp.TenHanhVi = _obj.TenHanhVi;
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
		
		public void Delete(LqHanhViEntity obj)
		{
			provider.GetTable<LqHanhViEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqHanhViEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqHanhViEntity ob = (LqHanhViEntity)q.First<LqHanhViEntity>();
            provider.GetTable<LqHanhViEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTenHanhVi(string TenHanhVi)
		{
			var q = from obj in provider.GetTable<LqHanhViEntity>()
                    where obj.TenHanhVi == TenHanhVi
                    select obj;
					
            LqHanhViEntity ob = (LqHanhViEntity)q.First<LqHanhViEntity>();
            provider.GetTable<LqHanhViEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdMaCha(Guid IdMaCha)
		{
			var q = from obj in provider.GetTable<LqHanhViEntity>()
                    where obj.IdMaCha.Value == IdMaCha
                    select obj;
					
            LqHanhViEntity ob = (LqHanhViEntity)q.First<LqHanhViEntity>();
            provider.GetTable<LqHanhViEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqHanhViEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqHanhViEntity ob = (LqHanhViEntity)q.First<LqHanhViEntity>();
            provider.GetTable<LqHanhViEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaTp(string MaTp)
		{
			var q = from obj in provider.GetTable<LqHanhViEntity>()
                    where obj.MaTp == MaTp
                    select obj;
					
            LqHanhViEntity ob = (LqHanhViEntity)q.First<LqHanhViEntity>();
            provider.GetTable<LqHanhViEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGhiChu(string GhiChu)
		{
			var q = from obj in provider.GetTable<LqHanhViEntity>()
                    where obj.GhiChu == GhiChu
                    select obj;
					
            LqHanhViEntity ob = (LqHanhViEntity)q.First<LqHanhViEntity>();
            provider.GetTable<LqHanhViEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var q = from obj in provider.GetTable<LqHanhViEntity>()
                    where obj.LoaiDanhMuc == LoaiDanhMuc
                    select obj;
					
            LqHanhViEntity ob = (LqHanhViEntity)q.First<LqHanhViEntity>();
            provider.GetTable<LqHanhViEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqHanhViEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqHanhViEntity ob = (LqHanhViEntity)q.First<LqHanhViEntity>();
            provider.GetTable<LqHanhViEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqHanhViEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqHanhViEntity ob = (LqHanhViEntity)q.First<LqHanhViEntity>();
            provider.GetTable<LqHanhViEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqHanhViEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqHanhViEntity ob = (LqHanhViEntity)q.First<LqHanhViEntity>();
            provider.GetTable<LqHanhViEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqHanhViEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqHanhViEntity ob = (LqHanhViEntity)q.First<LqHanhViEntity>();
            provider.GetTable<LqHanhViEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			var q = from obj in provider.GetTable<LqHanhViEntity>()
                    where obj.NgayHetHan.Value == NgayHetHan
                    select obj;
					
            LqHanhViEntity ob = (LqHanhViEntity)q.First<LqHanhViEntity>();
            provider.GetTable<LqHanhViEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqHanhViEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqHanhViEntity ob = (LqHanhViEntity)q.First<LqHanhViEntity>();
            provider.GetTable<LqHanhViEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqHanhViEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqHanhViEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqHanhViEntity>();
		}

		public List<LqHanhViEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqHanhViEntity>()
                        select obj;
            return query.ToList<LqHanhViEntity>();
		}
		
		
		public List<LqHanhViEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqHanhViEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqHanhViEntity>();
		}
		
		
		public List<LqHanhViEntity> SelectByTenHanhVi(string TenHanhVi)
		{
			var query = from obj in provider.GetTable<LqHanhViEntity>()
                        where obj.TenHanhVi == TenHanhVi
                        select obj;
            return query.ToList<LqHanhViEntity>();
		}
		
		
		public List<LqHanhViEntity> SelectByIdMaCha(Guid IdMaCha)
		{
			var query = from obj in provider.GetTable<LqHanhViEntity>()
                        where obj.IdMaCha.Value == IdMaCha
                        select obj;
            return query.ToList<LqHanhViEntity>();
		}
		
		
		public List<LqHanhViEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqHanhViEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqHanhViEntity>();
		}
		
		
		public List<LqHanhViEntity> SelectByMaTp(string MaTp)
		{
			var query = from obj in provider.GetTable<LqHanhViEntity>()
                        where obj.MaTp == MaTp
                        select obj;
            return query.ToList<LqHanhViEntity>();
		}
		
		
		public List<LqHanhViEntity> SelectByGhiChu(string GhiChu)
		{
			var query = from obj in provider.GetTable<LqHanhViEntity>()
                        where obj.GhiChu == GhiChu
                        select obj;
            return query.ToList<LqHanhViEntity>();
		}
		
		
		public List<LqHanhViEntity> SelectByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var query = from obj in provider.GetTable<LqHanhViEntity>()
                        where obj.LoaiDanhMuc == LoaiDanhMuc
                        select obj;
            return query.ToList<LqHanhViEntity>();
		}
		
		
		public List<LqHanhViEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqHanhViEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqHanhViEntity>();
		}
		
		
		public List<LqHanhViEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqHanhViEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqHanhViEntity>();
		}
		
		
		public List<LqHanhViEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqHanhViEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqHanhViEntity>();
		}
		
		
		public List<LqHanhViEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqHanhViEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqHanhViEntity>();
		}
		
		
		public List<LqHanhViEntity> SelectByNgayHetHan(DateTime NgayHetHan)
		{
			var query = from obj in provider.GetTable<LqHanhViEntity>()
                        where obj.NgayHetHan.Value == NgayHetHan
                        select obj;
            return query.ToList<LqHanhViEntity>();
		}
		
		
		public List<LqHanhViEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqHanhViEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqHanhViEntity>();
		}
		
		
		

	}
}
