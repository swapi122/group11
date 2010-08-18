




/*
'===============================================================================
'  LinqHelper.DAO.TinhChatLienQuanBase
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
	public class LqTinhChatLienQuanBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqTinhChatLienQuanBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqTinhChatLienQuanEntity obj)
		{
			provider.GetTable<LqTinhChatLienQuanEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqTinhChatLienQuanEntity _obj)
		{
			var q = from obj in provider.GetTable<LqTinhChatLienQuanEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqTinhChatLienQuanEntity tmp = q.First<LqTinhChatLienQuanEntity>();
			
			tmp.TenTinhChatLienQuan = _obj.TenTinhChatLienQuan;
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
		
		public void Delete(LqTinhChatLienQuanEntity obj)
		{
			provider.GetTable<LqTinhChatLienQuanEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqTinhChatLienQuanEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqTinhChatLienQuanEntity ob = (LqTinhChatLienQuanEntity)q.First<LqTinhChatLienQuanEntity>();
            provider.GetTable<LqTinhChatLienQuanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTenTinhChatLienQuan(string TenTinhChatLienQuan)
		{
			var q = from obj in provider.GetTable<LqTinhChatLienQuanEntity>()
                    where obj.TenTinhChatLienQuan == TenTinhChatLienQuan
                    select obj;
					
            LqTinhChatLienQuanEntity ob = (LqTinhChatLienQuanEntity)q.First<LqTinhChatLienQuanEntity>();
            provider.GetTable<LqTinhChatLienQuanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdMaCha(Guid IdMaCha)
		{
			var q = from obj in provider.GetTable<LqTinhChatLienQuanEntity>()
                    where obj.IdMaCha.Value == IdMaCha
                    select obj;
					
            LqTinhChatLienQuanEntity ob = (LqTinhChatLienQuanEntity)q.First<LqTinhChatLienQuanEntity>();
            provider.GetTable<LqTinhChatLienQuanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqTinhChatLienQuanEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqTinhChatLienQuanEntity ob = (LqTinhChatLienQuanEntity)q.First<LqTinhChatLienQuanEntity>();
            provider.GetTable<LqTinhChatLienQuanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaTp(string MaTp)
		{
			var q = from obj in provider.GetTable<LqTinhChatLienQuanEntity>()
                    where obj.MaTp == MaTp
                    select obj;
					
            LqTinhChatLienQuanEntity ob = (LqTinhChatLienQuanEntity)q.First<LqTinhChatLienQuanEntity>();
            provider.GetTable<LqTinhChatLienQuanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGhiChu(string GhiChu)
		{
			var q = from obj in provider.GetTable<LqTinhChatLienQuanEntity>()
                    where obj.GhiChu == GhiChu
                    select obj;
					
            LqTinhChatLienQuanEntity ob = (LqTinhChatLienQuanEntity)q.First<LqTinhChatLienQuanEntity>();
            provider.GetTable<LqTinhChatLienQuanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var q = from obj in provider.GetTable<LqTinhChatLienQuanEntity>()
                    where obj.LoaiDanhMuc == LoaiDanhMuc
                    select obj;
					
            LqTinhChatLienQuanEntity ob = (LqTinhChatLienQuanEntity)q.First<LqTinhChatLienQuanEntity>();
            provider.GetTable<LqTinhChatLienQuanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqTinhChatLienQuanEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqTinhChatLienQuanEntity ob = (LqTinhChatLienQuanEntity)q.First<LqTinhChatLienQuanEntity>();
            provider.GetTable<LqTinhChatLienQuanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqTinhChatLienQuanEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqTinhChatLienQuanEntity ob = (LqTinhChatLienQuanEntity)q.First<LqTinhChatLienQuanEntity>();
            provider.GetTable<LqTinhChatLienQuanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqTinhChatLienQuanEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqTinhChatLienQuanEntity ob = (LqTinhChatLienQuanEntity)q.First<LqTinhChatLienQuanEntity>();
            provider.GetTable<LqTinhChatLienQuanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqTinhChatLienQuanEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqTinhChatLienQuanEntity ob = (LqTinhChatLienQuanEntity)q.First<LqTinhChatLienQuanEntity>();
            provider.GetTable<LqTinhChatLienQuanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			var q = from obj in provider.GetTable<LqTinhChatLienQuanEntity>()
                    where obj.NgayHetHan.Value == NgayHetHan
                    select obj;
					
            LqTinhChatLienQuanEntity ob = (LqTinhChatLienQuanEntity)q.First<LqTinhChatLienQuanEntity>();
            provider.GetTable<LqTinhChatLienQuanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqTinhChatLienQuanEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqTinhChatLienQuanEntity ob = (LqTinhChatLienQuanEntity)q.First<LqTinhChatLienQuanEntity>();
            provider.GetTable<LqTinhChatLienQuanEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqTinhChatLienQuanEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqTinhChatLienQuanEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqTinhChatLienQuanEntity>();
		}

		public List<LqTinhChatLienQuanEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqTinhChatLienQuanEntity>()
                        select obj;
            return query.ToList<LqTinhChatLienQuanEntity>();
		}
		
		
		public List<LqTinhChatLienQuanEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqTinhChatLienQuanEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqTinhChatLienQuanEntity>();
		}
		
		
		public List<LqTinhChatLienQuanEntity> SelectByTenTinhChatLienQuan(string TenTinhChatLienQuan)
		{
			var query = from obj in provider.GetTable<LqTinhChatLienQuanEntity>()
                        where obj.TenTinhChatLienQuan == TenTinhChatLienQuan
                        select obj;
            return query.ToList<LqTinhChatLienQuanEntity>();
		}
		
		
		public List<LqTinhChatLienQuanEntity> SelectByIdMaCha(Guid IdMaCha)
		{
			var query = from obj in provider.GetTable<LqTinhChatLienQuanEntity>()
                        where obj.IdMaCha.Value == IdMaCha
                        select obj;
            return query.ToList<LqTinhChatLienQuanEntity>();
		}
		
		
		public List<LqTinhChatLienQuanEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqTinhChatLienQuanEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqTinhChatLienQuanEntity>();
		}
		
		
		public List<LqTinhChatLienQuanEntity> SelectByMaTp(string MaTp)
		{
			var query = from obj in provider.GetTable<LqTinhChatLienQuanEntity>()
                        where obj.MaTp == MaTp
                        select obj;
            return query.ToList<LqTinhChatLienQuanEntity>();
		}
		
		
		public List<LqTinhChatLienQuanEntity> SelectByGhiChu(string GhiChu)
		{
			var query = from obj in provider.GetTable<LqTinhChatLienQuanEntity>()
                        where obj.GhiChu == GhiChu
                        select obj;
            return query.ToList<LqTinhChatLienQuanEntity>();
		}
		
		
		public List<LqTinhChatLienQuanEntity> SelectByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var query = from obj in provider.GetTable<LqTinhChatLienQuanEntity>()
                        where obj.LoaiDanhMuc == LoaiDanhMuc
                        select obj;
            return query.ToList<LqTinhChatLienQuanEntity>();
		}
		
		
		public List<LqTinhChatLienQuanEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqTinhChatLienQuanEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqTinhChatLienQuanEntity>();
		}
		
		
		public List<LqTinhChatLienQuanEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqTinhChatLienQuanEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqTinhChatLienQuanEntity>();
		}
		
		
		public List<LqTinhChatLienQuanEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqTinhChatLienQuanEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqTinhChatLienQuanEntity>();
		}
		
		
		public List<LqTinhChatLienQuanEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqTinhChatLienQuanEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqTinhChatLienQuanEntity>();
		}
		
		
		public List<LqTinhChatLienQuanEntity> SelectByNgayHetHan(DateTime NgayHetHan)
		{
			var query = from obj in provider.GetTable<LqTinhChatLienQuanEntity>()
                        where obj.NgayHetHan.Value == NgayHetHan
                        select obj;
            return query.ToList<LqTinhChatLienQuanEntity>();
		}
		
		
		public List<LqTinhChatLienQuanEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqTinhChatLienQuanEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqTinhChatLienQuanEntity>();
		}
		
		
		

	}
}
