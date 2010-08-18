




/*
'===============================================================================
'  LinqHelper.DAO.PhanLoaiChuyenDeBase
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
	public class LqPhanLoaiChuyenDeBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqPhanLoaiChuyenDeBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqPhanLoaiChuyenDeEntity obj)
		{
			provider.GetTable<LqPhanLoaiChuyenDeEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqPhanLoaiChuyenDeEntity _obj)
		{
			var q = from obj in provider.GetTable<LqPhanLoaiChuyenDeEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqPhanLoaiChuyenDeEntity tmp = q.First<LqPhanLoaiChuyenDeEntity>();
			
			tmp.TenPhanLoaiChuyenDe = _obj.TenPhanLoaiChuyenDe;
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
		
		public void Delete(LqPhanLoaiChuyenDeEntity obj)
		{
			provider.GetTable<LqPhanLoaiChuyenDeEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqPhanLoaiChuyenDeEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqPhanLoaiChuyenDeEntity ob = (LqPhanLoaiChuyenDeEntity)q.First<LqPhanLoaiChuyenDeEntity>();
            provider.GetTable<LqPhanLoaiChuyenDeEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTenPhanLoaiChuyenDe(string TenPhanLoaiChuyenDe)
		{
			var q = from obj in provider.GetTable<LqPhanLoaiChuyenDeEntity>()
                    where obj.TenPhanLoaiChuyenDe == TenPhanLoaiChuyenDe
                    select obj;
					
            LqPhanLoaiChuyenDeEntity ob = (LqPhanLoaiChuyenDeEntity)q.First<LqPhanLoaiChuyenDeEntity>();
            provider.GetTable<LqPhanLoaiChuyenDeEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdMaCha(Guid IdMaCha)
		{
			var q = from obj in provider.GetTable<LqPhanLoaiChuyenDeEntity>()
                    where obj.IdMaCha.Value == IdMaCha
                    select obj;
					
            LqPhanLoaiChuyenDeEntity ob = (LqPhanLoaiChuyenDeEntity)q.First<LqPhanLoaiChuyenDeEntity>();
            provider.GetTable<LqPhanLoaiChuyenDeEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqPhanLoaiChuyenDeEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqPhanLoaiChuyenDeEntity ob = (LqPhanLoaiChuyenDeEntity)q.First<LqPhanLoaiChuyenDeEntity>();
            provider.GetTable<LqPhanLoaiChuyenDeEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaTp(string MaTp)
		{
			var q = from obj in provider.GetTable<LqPhanLoaiChuyenDeEntity>()
                    where obj.MaTp == MaTp
                    select obj;
					
            LqPhanLoaiChuyenDeEntity ob = (LqPhanLoaiChuyenDeEntity)q.First<LqPhanLoaiChuyenDeEntity>();
            provider.GetTable<LqPhanLoaiChuyenDeEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGhiChu(string GhiChu)
		{
			var q = from obj in provider.GetTable<LqPhanLoaiChuyenDeEntity>()
                    where obj.GhiChu == GhiChu
                    select obj;
					
            LqPhanLoaiChuyenDeEntity ob = (LqPhanLoaiChuyenDeEntity)q.First<LqPhanLoaiChuyenDeEntity>();
            provider.GetTable<LqPhanLoaiChuyenDeEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var q = from obj in provider.GetTable<LqPhanLoaiChuyenDeEntity>()
                    where obj.LoaiDanhMuc == LoaiDanhMuc
                    select obj;
					
            LqPhanLoaiChuyenDeEntity ob = (LqPhanLoaiChuyenDeEntity)q.First<LqPhanLoaiChuyenDeEntity>();
            provider.GetTable<LqPhanLoaiChuyenDeEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqPhanLoaiChuyenDeEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqPhanLoaiChuyenDeEntity ob = (LqPhanLoaiChuyenDeEntity)q.First<LqPhanLoaiChuyenDeEntity>();
            provider.GetTable<LqPhanLoaiChuyenDeEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqPhanLoaiChuyenDeEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqPhanLoaiChuyenDeEntity ob = (LqPhanLoaiChuyenDeEntity)q.First<LqPhanLoaiChuyenDeEntity>();
            provider.GetTable<LqPhanLoaiChuyenDeEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqPhanLoaiChuyenDeEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqPhanLoaiChuyenDeEntity ob = (LqPhanLoaiChuyenDeEntity)q.First<LqPhanLoaiChuyenDeEntity>();
            provider.GetTable<LqPhanLoaiChuyenDeEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqPhanLoaiChuyenDeEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqPhanLoaiChuyenDeEntity ob = (LqPhanLoaiChuyenDeEntity)q.First<LqPhanLoaiChuyenDeEntity>();
            provider.GetTable<LqPhanLoaiChuyenDeEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			var q = from obj in provider.GetTable<LqPhanLoaiChuyenDeEntity>()
                    where obj.NgayHetHan.Value == NgayHetHan
                    select obj;
					
            LqPhanLoaiChuyenDeEntity ob = (LqPhanLoaiChuyenDeEntity)q.First<LqPhanLoaiChuyenDeEntity>();
            provider.GetTable<LqPhanLoaiChuyenDeEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqPhanLoaiChuyenDeEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqPhanLoaiChuyenDeEntity ob = (LqPhanLoaiChuyenDeEntity)q.First<LqPhanLoaiChuyenDeEntity>();
            provider.GetTable<LqPhanLoaiChuyenDeEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqPhanLoaiChuyenDeEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqPhanLoaiChuyenDeEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqPhanLoaiChuyenDeEntity>();
		}

		public List<LqPhanLoaiChuyenDeEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqPhanLoaiChuyenDeEntity>()
                        select obj;
            return query.ToList<LqPhanLoaiChuyenDeEntity>();
		}
		
		
		public List<LqPhanLoaiChuyenDeEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqPhanLoaiChuyenDeEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqPhanLoaiChuyenDeEntity>();
		}
		
		
		public List<LqPhanLoaiChuyenDeEntity> SelectByTenPhanLoaiChuyenDe(string TenPhanLoaiChuyenDe)
		{
			var query = from obj in provider.GetTable<LqPhanLoaiChuyenDeEntity>()
                        where obj.TenPhanLoaiChuyenDe == TenPhanLoaiChuyenDe
                        select obj;
            return query.ToList<LqPhanLoaiChuyenDeEntity>();
		}
		
		
		public List<LqPhanLoaiChuyenDeEntity> SelectByIdMaCha(Guid IdMaCha)
		{
			var query = from obj in provider.GetTable<LqPhanLoaiChuyenDeEntity>()
                        where obj.IdMaCha.Value == IdMaCha
                        select obj;
            return query.ToList<LqPhanLoaiChuyenDeEntity>();
		}
		
		
		public List<LqPhanLoaiChuyenDeEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqPhanLoaiChuyenDeEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqPhanLoaiChuyenDeEntity>();
		}
		
		
		public List<LqPhanLoaiChuyenDeEntity> SelectByMaTp(string MaTp)
		{
			var query = from obj in provider.GetTable<LqPhanLoaiChuyenDeEntity>()
                        where obj.MaTp == MaTp
                        select obj;
            return query.ToList<LqPhanLoaiChuyenDeEntity>();
		}
		
		
		public List<LqPhanLoaiChuyenDeEntity> SelectByGhiChu(string GhiChu)
		{
			var query = from obj in provider.GetTable<LqPhanLoaiChuyenDeEntity>()
                        where obj.GhiChu == GhiChu
                        select obj;
            return query.ToList<LqPhanLoaiChuyenDeEntity>();
		}
		
		
		public List<LqPhanLoaiChuyenDeEntity> SelectByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var query = from obj in provider.GetTable<LqPhanLoaiChuyenDeEntity>()
                        where obj.LoaiDanhMuc == LoaiDanhMuc
                        select obj;
            return query.ToList<LqPhanLoaiChuyenDeEntity>();
		}
		
		
		public List<LqPhanLoaiChuyenDeEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqPhanLoaiChuyenDeEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqPhanLoaiChuyenDeEntity>();
		}
		
		
		public List<LqPhanLoaiChuyenDeEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqPhanLoaiChuyenDeEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqPhanLoaiChuyenDeEntity>();
		}
		
		
		public List<LqPhanLoaiChuyenDeEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqPhanLoaiChuyenDeEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqPhanLoaiChuyenDeEntity>();
		}
		
		
		public List<LqPhanLoaiChuyenDeEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqPhanLoaiChuyenDeEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqPhanLoaiChuyenDeEntity>();
		}
		
		
		public List<LqPhanLoaiChuyenDeEntity> SelectByNgayHetHan(DateTime NgayHetHan)
		{
			var query = from obj in provider.GetTable<LqPhanLoaiChuyenDeEntity>()
                        where obj.NgayHetHan.Value == NgayHetHan
                        select obj;
            return query.ToList<LqPhanLoaiChuyenDeEntity>();
		}
		
		
		public List<LqPhanLoaiChuyenDeEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqPhanLoaiChuyenDeEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqPhanLoaiChuyenDeEntity>();
		}
		
		
		

	}
}
