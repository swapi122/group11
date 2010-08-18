




/*
'===============================================================================
'  LinqHelper.DAO.DanhMucTinBase
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
	public class LqDanhMucTinBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqDanhMucTinBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqDanhMucTinEntity obj)
		{
			provider.GetTable<LqDanhMucTinEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqDanhMucTinEntity _obj)
		{
			var q = from obj in provider.GetTable<LqDanhMucTinEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqDanhMucTinEntity tmp = q.First<LqDanhMucTinEntity>();
			
			tmp.TenDanhMucTin = _obj.TenDanhMucTin;
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
		
		public void Delete(LqDanhMucTinEntity obj)
		{
			provider.GetTable<LqDanhMucTinEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqDanhMucTinEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqDanhMucTinEntity ob = (LqDanhMucTinEntity)q.First<LqDanhMucTinEntity>();
            provider.GetTable<LqDanhMucTinEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTenDanhMucTin(string TenDanhMucTin)
		{
			var q = from obj in provider.GetTable<LqDanhMucTinEntity>()
                    where obj.TenDanhMucTin == TenDanhMucTin
                    select obj;
					
            LqDanhMucTinEntity ob = (LqDanhMucTinEntity)q.First<LqDanhMucTinEntity>();
            provider.GetTable<LqDanhMucTinEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdMaCha(Guid IdMaCha)
		{
			var q = from obj in provider.GetTable<LqDanhMucTinEntity>()
                    where obj.IdMaCha.Value == IdMaCha
                    select obj;
					
            LqDanhMucTinEntity ob = (LqDanhMucTinEntity)q.First<LqDanhMucTinEntity>();
            provider.GetTable<LqDanhMucTinEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqDanhMucTinEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqDanhMucTinEntity ob = (LqDanhMucTinEntity)q.First<LqDanhMucTinEntity>();
            provider.GetTable<LqDanhMucTinEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaTp(string MaTp)
		{
			var q = from obj in provider.GetTable<LqDanhMucTinEntity>()
                    where obj.MaTp == MaTp
                    select obj;
					
            LqDanhMucTinEntity ob = (LqDanhMucTinEntity)q.First<LqDanhMucTinEntity>();
            provider.GetTable<LqDanhMucTinEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGhiChu(string GhiChu)
		{
			var q = from obj in provider.GetTable<LqDanhMucTinEntity>()
                    where obj.GhiChu == GhiChu
                    select obj;
					
            LqDanhMucTinEntity ob = (LqDanhMucTinEntity)q.First<LqDanhMucTinEntity>();
            provider.GetTable<LqDanhMucTinEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var q = from obj in provider.GetTable<LqDanhMucTinEntity>()
                    where obj.LoaiDanhMuc == LoaiDanhMuc
                    select obj;
					
            LqDanhMucTinEntity ob = (LqDanhMucTinEntity)q.First<LqDanhMucTinEntity>();
            provider.GetTable<LqDanhMucTinEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqDanhMucTinEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqDanhMucTinEntity ob = (LqDanhMucTinEntity)q.First<LqDanhMucTinEntity>();
            provider.GetTable<LqDanhMucTinEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqDanhMucTinEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqDanhMucTinEntity ob = (LqDanhMucTinEntity)q.First<LqDanhMucTinEntity>();
            provider.GetTable<LqDanhMucTinEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqDanhMucTinEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqDanhMucTinEntity ob = (LqDanhMucTinEntity)q.First<LqDanhMucTinEntity>();
            provider.GetTable<LqDanhMucTinEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqDanhMucTinEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqDanhMucTinEntity ob = (LqDanhMucTinEntity)q.First<LqDanhMucTinEntity>();
            provider.GetTable<LqDanhMucTinEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			var q = from obj in provider.GetTable<LqDanhMucTinEntity>()
                    where obj.NgayHetHan.Value == NgayHetHan
                    select obj;
					
            LqDanhMucTinEntity ob = (LqDanhMucTinEntity)q.First<LqDanhMucTinEntity>();
            provider.GetTable<LqDanhMucTinEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqDanhMucTinEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqDanhMucTinEntity ob = (LqDanhMucTinEntity)q.First<LqDanhMucTinEntity>();
            provider.GetTable<LqDanhMucTinEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqDanhMucTinEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqDanhMucTinEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqDanhMucTinEntity>();
		}

		public List<LqDanhMucTinEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqDanhMucTinEntity>()
                        select obj;
            return query.ToList<LqDanhMucTinEntity>();
		}
		
		
		public List<LqDanhMucTinEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqDanhMucTinEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqDanhMucTinEntity>();
		}
		
		
		public List<LqDanhMucTinEntity> SelectByTenDanhMucTin(string TenDanhMucTin)
		{
			var query = from obj in provider.GetTable<LqDanhMucTinEntity>()
                        where obj.TenDanhMucTin == TenDanhMucTin
                        select obj;
            return query.ToList<LqDanhMucTinEntity>();
		}
		
		
		public List<LqDanhMucTinEntity> SelectByIdMaCha(Guid IdMaCha)
		{
			var query = from obj in provider.GetTable<LqDanhMucTinEntity>()
                        where obj.IdMaCha.Value == IdMaCha
                        select obj;
            return query.ToList<LqDanhMucTinEntity>();
		}
		
		
		public List<LqDanhMucTinEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqDanhMucTinEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqDanhMucTinEntity>();
		}
		
		
		public List<LqDanhMucTinEntity> SelectByMaTp(string MaTp)
		{
			var query = from obj in provider.GetTable<LqDanhMucTinEntity>()
                        where obj.MaTp == MaTp
                        select obj;
            return query.ToList<LqDanhMucTinEntity>();
		}
		
		
		public List<LqDanhMucTinEntity> SelectByGhiChu(string GhiChu)
		{
			var query = from obj in provider.GetTable<LqDanhMucTinEntity>()
                        where obj.GhiChu == GhiChu
                        select obj;
            return query.ToList<LqDanhMucTinEntity>();
		}
		
		
		public List<LqDanhMucTinEntity> SelectByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var query = from obj in provider.GetTable<LqDanhMucTinEntity>()
                        where obj.LoaiDanhMuc == LoaiDanhMuc
                        select obj;
            return query.ToList<LqDanhMucTinEntity>();
		}
		
		
		public List<LqDanhMucTinEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqDanhMucTinEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqDanhMucTinEntity>();
		}
		
		
		public List<LqDanhMucTinEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqDanhMucTinEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqDanhMucTinEntity>();
		}
		
		
		public List<LqDanhMucTinEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqDanhMucTinEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqDanhMucTinEntity>();
		}
		
		
		public List<LqDanhMucTinEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqDanhMucTinEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqDanhMucTinEntity>();
		}
		
		
		public List<LqDanhMucTinEntity> SelectByNgayHetHan(DateTime NgayHetHan)
		{
			var query = from obj in provider.GetTable<LqDanhMucTinEntity>()
                        where obj.NgayHetHan.Value == NgayHetHan
                        select obj;
            return query.ToList<LqDanhMucTinEntity>();
		}
		
		
		public List<LqDanhMucTinEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqDanhMucTinEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqDanhMucTinEntity>();
		}
		
		
		

	}
}
