




/*
'===============================================================================
'  LinqHelper.DAO.DonViCongAnBase
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
	public class LqDonViCongAnBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqDonViCongAnBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqDonViCongAnEntity obj)
		{
			provider.GetTable<LqDonViCongAnEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqDonViCongAnEntity _obj)
		{
			var q = from obj in provider.GetTable<LqDonViCongAnEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqDonViCongAnEntity tmp = q.First<LqDonViCongAnEntity>();
			
			tmp.TenDonViCongAn = _obj.TenDonViCongAn;
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
		
		public void Delete(LqDonViCongAnEntity obj)
		{
			provider.GetTable<LqDonViCongAnEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqDonViCongAnEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqDonViCongAnEntity ob = (LqDonViCongAnEntity)q.First<LqDonViCongAnEntity>();
            provider.GetTable<LqDonViCongAnEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTenDonViCongAn(string TenDonViCongAn)
		{
			var q = from obj in provider.GetTable<LqDonViCongAnEntity>()
                    where obj.TenDonViCongAn == TenDonViCongAn
                    select obj;
					
            LqDonViCongAnEntity ob = (LqDonViCongAnEntity)q.First<LqDonViCongAnEntity>();
            provider.GetTable<LqDonViCongAnEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdMaCha(Guid IdMaCha)
		{
			var q = from obj in provider.GetTable<LqDonViCongAnEntity>()
                    where obj.IdMaCha.Value == IdMaCha
                    select obj;
					
            LqDonViCongAnEntity ob = (LqDonViCongAnEntity)q.First<LqDonViCongAnEntity>();
            provider.GetTable<LqDonViCongAnEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqDonViCongAnEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqDonViCongAnEntity ob = (LqDonViCongAnEntity)q.First<LqDonViCongAnEntity>();
            provider.GetTable<LqDonViCongAnEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaTp(string MaTp)
		{
			var q = from obj in provider.GetTable<LqDonViCongAnEntity>()
                    where obj.MaTp == MaTp
                    select obj;
					
            LqDonViCongAnEntity ob = (LqDonViCongAnEntity)q.First<LqDonViCongAnEntity>();
            provider.GetTable<LqDonViCongAnEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGhiChu(string GhiChu)
		{
			var q = from obj in provider.GetTable<LqDonViCongAnEntity>()
                    where obj.GhiChu == GhiChu
                    select obj;
					
            LqDonViCongAnEntity ob = (LqDonViCongAnEntity)q.First<LqDonViCongAnEntity>();
            provider.GetTable<LqDonViCongAnEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var q = from obj in provider.GetTable<LqDonViCongAnEntity>()
                    where obj.LoaiDanhMuc == LoaiDanhMuc
                    select obj;
					
            LqDonViCongAnEntity ob = (LqDonViCongAnEntity)q.First<LqDonViCongAnEntity>();
            provider.GetTable<LqDonViCongAnEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqDonViCongAnEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqDonViCongAnEntity ob = (LqDonViCongAnEntity)q.First<LqDonViCongAnEntity>();
            provider.GetTable<LqDonViCongAnEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqDonViCongAnEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqDonViCongAnEntity ob = (LqDonViCongAnEntity)q.First<LqDonViCongAnEntity>();
            provider.GetTable<LqDonViCongAnEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqDonViCongAnEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqDonViCongAnEntity ob = (LqDonViCongAnEntity)q.First<LqDonViCongAnEntity>();
            provider.GetTable<LqDonViCongAnEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqDonViCongAnEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqDonViCongAnEntity ob = (LqDonViCongAnEntity)q.First<LqDonViCongAnEntity>();
            provider.GetTable<LqDonViCongAnEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			var q = from obj in provider.GetTable<LqDonViCongAnEntity>()
                    where obj.NgayHetHan.Value == NgayHetHan
                    select obj;
					
            LqDonViCongAnEntity ob = (LqDonViCongAnEntity)q.First<LqDonViCongAnEntity>();
            provider.GetTable<LqDonViCongAnEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqDonViCongAnEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqDonViCongAnEntity ob = (LqDonViCongAnEntity)q.First<LqDonViCongAnEntity>();
            provider.GetTable<LqDonViCongAnEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqDonViCongAnEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqDonViCongAnEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqDonViCongAnEntity>();
		}

		public List<LqDonViCongAnEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqDonViCongAnEntity>()
                        select obj;
            return query.ToList<LqDonViCongAnEntity>();
		}
		
		
		public List<LqDonViCongAnEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqDonViCongAnEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqDonViCongAnEntity>();
		}
		
		
		public List<LqDonViCongAnEntity> SelectByTenDonViCongAn(string TenDonViCongAn)
		{
			var query = from obj in provider.GetTable<LqDonViCongAnEntity>()
                        where obj.TenDonViCongAn == TenDonViCongAn
                        select obj;
            return query.ToList<LqDonViCongAnEntity>();
		}
		
		
		public List<LqDonViCongAnEntity> SelectByIdMaCha(Guid IdMaCha)
		{
			var query = from obj in provider.GetTable<LqDonViCongAnEntity>()
                        where obj.IdMaCha.Value == IdMaCha
                        select obj;
            return query.ToList<LqDonViCongAnEntity>();
		}
		
		
		public List<LqDonViCongAnEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqDonViCongAnEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqDonViCongAnEntity>();
		}
		
		
		public List<LqDonViCongAnEntity> SelectByMaTp(string MaTp)
		{
			var query = from obj in provider.GetTable<LqDonViCongAnEntity>()
                        where obj.MaTp == MaTp
                        select obj;
            return query.ToList<LqDonViCongAnEntity>();
		}
		
		
		public List<LqDonViCongAnEntity> SelectByGhiChu(string GhiChu)
		{
			var query = from obj in provider.GetTable<LqDonViCongAnEntity>()
                        where obj.GhiChu == GhiChu
                        select obj;
            return query.ToList<LqDonViCongAnEntity>();
		}
		
		
		public List<LqDonViCongAnEntity> SelectByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var query = from obj in provider.GetTable<LqDonViCongAnEntity>()
                        where obj.LoaiDanhMuc == LoaiDanhMuc
                        select obj;
            return query.ToList<LqDonViCongAnEntity>();
		}
		
		
		public List<LqDonViCongAnEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqDonViCongAnEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqDonViCongAnEntity>();
		}
		
		
		public List<LqDonViCongAnEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqDonViCongAnEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqDonViCongAnEntity>();
		}
		
		
		public List<LqDonViCongAnEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqDonViCongAnEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqDonViCongAnEntity>();
		}
		
		
		public List<LqDonViCongAnEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqDonViCongAnEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqDonViCongAnEntity>();
		}
		
		
		public List<LqDonViCongAnEntity> SelectByNgayHetHan(DateTime NgayHetHan)
		{
			var query = from obj in provider.GetTable<LqDonViCongAnEntity>()
                        where obj.NgayHetHan.Value == NgayHetHan
                        select obj;
            return query.ToList<LqDonViCongAnEntity>();
		}
		
		
		public List<LqDonViCongAnEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqDonViCongAnEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqDonViCongAnEntity>();
		}
		
		
		

	}
}
